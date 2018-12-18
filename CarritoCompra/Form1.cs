using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Media;
using System.Linq;

namespace CarritoCompra
{
    public partial class Form1 : Form
    {
        private SoundPlayer Player = new SoundPlayer(); //No implementado (aún)
        string[] nombresHamburguesas = new string[] {"CBO","Cuarto de libra", "Big Mac", "Big Crispy Barbacoa", "Macroyal Deluxe", "MacRuap"};
        double[] precioHamburguesas = new double[] {4.90, 4, 4.50, 5, 3.70, 4.40};
        string[] nombresBebidas = new string[] {"Coca cola", "Fanta", "Nestea", "KAS", "Zumo", "Agua"};
        double[] precioBebidas = new double[] {3.50, 3.50, 2.40, 3, 2.50, 1.60};
        string[] nombresComplementos = new string[] {"Top frais barbacoa", "Camembert", "Macnaguets", "Alitas", "MacBaits", "MacCroquetas"};
        double[] precioComplementos = new double[] {4, 3.50, 4.20, 5, 3.70, 3.50};
        string[] nombresPostres = new string[] {"MacFlurry", "MacSheik", "Sandi", "Cono de helado", "Piña", "Manzana"};
        double[] precioPostres = new double[] {2.50, 2.25, 1.90, 1, 1.50, 1.50};
        string[] nombresMenus = new string[] {"Menú CBO", "Menú cuarto de libra", "Menú Big Mac", "Menú Big Crispy Barbacoa", "Menú MacRoyal Deluxe", "Menú MacRuap"};
        double[] precioMenus = new double[] {8.50, 6.70, 5.90, 6.20, 7.40, 7.30};
        string oferta = "MacNífico";
        double precioOferta = 3.90;
        double cuentaTotal = 0.0;
        double precioTotal = 0.0;
        int orden = 0;

        string pantalla = "menuPrincipal"; //Variable que cambia en función de la pantalla en la que estemos para la función de pedir una opción
        string[] amenazasNoPagar = new string[] {"Voy a llamar a la policia", "Por favor, seguridad", "No te lo crees ni tú", "Si no pagas tú, yo no voy a pagar"};

        private System.Speech.Recognition.SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        private SpeechSynthesizer synth = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            synth.Speak("Bienvendo al ASISTENTE por voz de MacDonalds ESPAÑA!");
            synth.Speak("¿Qué desea pedir?");

            Grammar grammar = CreateGrammarBuilderMcDonaldsSemantics(null);
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.UnloadAllGrammars();
            _recognizer.UpdateRecognizerSetting("CFGConfidenceRejectionThreshold", 60);
            grammar.Enabled = true;
            _recognizer.LoadGrammar(grammar);
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_recognizer_SpeechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            menuPrincipalControl1.BringToFront();
        }

        void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            SemanticValue semantics = e.Result.Semantics;

            string rawText = e.Result.Text;
            RecognitionResult result = e.Result;

            if (semantics.ContainsKey("menu"))
            {
                ///Recoger opción
                switch (semantics["menu"].Value)
                {
                    case "hamburguesas":
                        hamburguesasControl1.BringToFront();
                        pantalla = "hamburguesas";
                        this.labelSeccion.Text += " / Hamburguesas";
                        Update();
                        break;
                    case "bebidas":
                        bebidasControl1.BringToFront();
                        pantalla = "bebidas";
                        this.labelSeccion.Text += " / Bebidas";
                        Update();
                        break;
                    case "complementos":
                        complementosControl1.BringToFront();
                        pantalla = "complementos";
                        this.labelSeccion.Text += " / Complementos";
                        Update();
                        break;
                    case "postres":
                        postresControl1.BringToFront();
                        pantalla = "postres";
                        this.labelSeccion.Text += " / Postres";
                        Update();
                        break;
                    case "menús":
                        menusControl1.BringToFront();
                        pantalla = "menús";
                        this.labelSeccion.Text += " / Menús";
                        Update();
                        break;
                    case "ofertas":
                        ofertaSemanalControl1.BringToFront();
                        pantalla = "oferta";
                        this.labelSeccion.Text += " / Ofertas";
                        Update();
                        break;
                }
            }
            else if (semantics.ContainsKey("opcion"))
            {
                orden = (int)semantics["opcion"].Value;
                ///Recoger opción
                switch (pantalla)
                {
                    case "menuPrincipal":
                        synth.Speak("Primero debe ir a alguna de las categorías de los productos para poder pedir algún número.");
                        Update();
                        break;
                    case "hamburguesas":
                        cuentaTotal += precioHamburguesas[orden - 1];
                        synth.Speak("Has añadido un" + nombresHamburguesas[orden - 1] + "por valor de" + precioHamburguesas[orden - 1] + "euros");
                        Update();
                        break;
                    case "bebidas":
                        cuentaTotal += precioBebidas[orden - 1];
                        synth.Speak("Has añadido un" + nombresBebidas[orden - 1] + "por valor de" + precioBebidas[orden - 1] + "euros");
                        Update();
                        break;
                    case "complementos":
                        cuentaTotal += precioComplementos[orden - 1];
                        synth.Speak("Has añadido un" + nombresComplementos[orden - 1] + "por valor de" + precioComplementos[orden - 1] + "euros");
                        Update();
                        break;
                    case "postres":
                        cuentaTotal += precioPostres[orden - 1];
                        synth.Speak("Has añadido un" + nombresPostres[orden - 1] + "por valor de" + precioPostres[orden - 1] + "euros");
                        Update();
                        break;
                    case "menús":
                        cuentaTotal += precioComplementos[orden - 1];
                        synth.Speak("Has añadido un" + nombresMenus[orden - 1] + "por valor de" + precioMenus[orden - 1] + "euros");
                        Update();
                        break;
                    case "oferta":
                        cuentaTotal += precioOferta;
                        synth.Speak("Has añadido la oferta Macnífico por valor de" + precioOferta + "euros");
                        Update();
                        break;
                }
            }
            else if (semantics.ContainsKey("cerrar"))
            {
                synth.Speak("Ha sido un placer, que tenga un buen día.");
                Application.Exit();
            }
            else if (semantics.ContainsKey("recomendar"))
            {
                var seed = Environment.TickCount;
                var random = new Random(seed);
                var value = random.Next(1, 6);
                Update();
                synth.Speak("Te recomiendo la opción número" + value);
            }
            else if (semantics.ContainsKey("noPagar"))
            {
                var seed = Environment.TickCount;
                var random = new Random(seed);
                var value = random.Next(0, 3);
                Update();
                synth.Speak(amenazasNoPagar[value]);
            }
            else if (semantics.ContainsKey("recuentoTotal"))
            {
                precioTotal = 0.0;
                precioTotal = cuentaTotal;
                Update();
                synth.Speak("Su cuenta es de"+precioTotal+"euros");
            }else if (semantics.ContainsKey("atras"))
            {
                menuPrincipalControl1.BringToFront();
                Update();
                this.labelSeccion.Text = "Menú Principal";
                pantalla = "menuPrincipal";
            }

        }

        void _recognizer_SpeechRecognized(object sender, SpeechHypothesizedEventArgs e) {}

        private Grammar CreateGrammarBuilderMcDonaldsSemantics(params int[] info)
        {

            Choices choiceOpciones = new Choices();
            Choices navegacionMenuPrincipal = new Choices();
            Choices opcionesRecomendar = new Choices();
            Choices cerrarSalir = new Choices();
            Choices noPagar = new Choices();

            ///Creación de las choices para los números de las opciones
          
            SemanticResultValue choiceResultValue = new SemanticResultValue("Uno", 1);
            GrammarBuilder resultValueBuilder = new GrammarBuilder(choiceResultValue);
            choiceOpciones.Add(resultValueBuilder);

            choiceResultValue = new SemanticResultValue("Dos", 2);
            resultValueBuilder = new GrammarBuilder(choiceResultValue);
            choiceOpciones.Add(resultValueBuilder);

            choiceResultValue = new SemanticResultValue("Tres", 3);
            resultValueBuilder = new GrammarBuilder(choiceResultValue);
            choiceOpciones.Add(resultValueBuilder);

            choiceResultValue = new SemanticResultValue("Cuatro", 4);
            resultValueBuilder = new GrammarBuilder(choiceResultValue);
            choiceOpciones.Add(resultValueBuilder);

            choiceResultValue = new SemanticResultValue("Cinco", 5);
            resultValueBuilder = new GrammarBuilder(choiceResultValue);
            choiceOpciones.Add(resultValueBuilder);

            choiceResultValue = new SemanticResultValue("Seis", 6);
            resultValueBuilder = new GrammarBuilder(choiceResultValue);
            choiceOpciones.Add(resultValueBuilder);

            ///Creación de las choices para seleccionar en el menú principal

            SemanticResultValue choiceResultValue2 = new SemanticResultValue("Hamburguesas","hamburguesas");
            GrammarBuilder resultValueBuilder2 = new GrammarBuilder(choiceResultValue2);
            navegacionMenuPrincipal.Add(resultValueBuilder2);

            choiceResultValue2 = new SemanticResultValue("Bebidas", "bebidas");
            resultValueBuilder2 = new GrammarBuilder(choiceResultValue2);
            navegacionMenuPrincipal.Add(resultValueBuilder2);

            choiceResultValue2 = new SemanticResultValue("Complementos", "complementos");
            resultValueBuilder2 = new GrammarBuilder(choiceResultValue2);
            navegacionMenuPrincipal.Add(resultValueBuilder2);

            choiceResultValue2 = new SemanticResultValue("Postres", "postres");
            resultValueBuilder2 = new GrammarBuilder(choiceResultValue2);
            navegacionMenuPrincipal.Add(resultValueBuilder2);

            choiceResultValue2 = new SemanticResultValue("Menús", "menús");
            resultValueBuilder2 = new GrammarBuilder(choiceResultValue2);
            navegacionMenuPrincipal.Add(resultValueBuilder2);

            choiceResultValue2 = new SemanticResultValue("Ofertas", "ofertas");
            resultValueBuilder2 = new GrammarBuilder(choiceResultValue2);
            navegacionMenuPrincipal.Add(resultValueBuilder2);

            ///Creación de las choices para salir

            SemanticResultValue choiceResultValue3 = new SemanticResultValue("Salir", "salir");
            GrammarBuilder resultValueBuilder3 = new GrammarBuilder(choiceResultValue3);
            cerrarSalir.Add(resultValueBuilder3);

            choiceResultValue3 = new SemanticResultValue("Cerrar", "cerrar");
            resultValueBuilder3 = new GrammarBuilder(choiceResultValue3);
            cerrarSalir.Add(resultValueBuilder3);

            ///Creación de las choices para la recomendación
            
            SemanticResultValue choiceResultValue4 = new SemanticResultValue("Recomiendas", "recomiendas");
            GrammarBuilder resultValueBuilder4 = new GrammarBuilder(choiceResultValue4);
            opcionesRecomendar.Add(resultValueBuilder4);

            choiceResultValue4 = new SemanticResultValue("Propones", "propones");
            resultValueBuilder4 = new GrammarBuilder(choiceResultValue4);
            opcionesRecomendar.Add(resultValueBuilder4);

            ///Creación de las choices para no pagar

            SemanticResultValue choiceResultValue5 = new SemanticResultValue("voy a", "voy a");
            GrammarBuilder resultValueBuilder5 = new GrammarBuilder(choiceResultValue5);
            noPagar.Add(resultValueBuilder5);

            choiceResultValue5 = new SemanticResultValue("quiero", "quiero");
            resultValueBuilder5 = new GrammarBuilder(choiceResultValue5);
            noPagar.Add(resultValueBuilder5);

            ///Creando las keys

            SemanticResultKey choiceResultKey = new SemanticResultKey("opcion",choiceOpciones);
            GrammarBuilder opciones = new GrammarBuilder(choiceResultKey);

            SemanticResultKey choiceResultKey2 = new SemanticResultKey("menu", navegacionMenuPrincipal);
            GrammarBuilder menuPrincipal = new GrammarBuilder(choiceResultKey2);

            SemanticResultKey choiceResultKey3 = new SemanticResultKey("cerrar", cerrarSalir);
            GrammarBuilder cerrarExit = new GrammarBuilder(choiceResultKey3);

            SemanticResultKey choiceResultKey4 = new SemanticResultKey("recomendar", opcionesRecomendar);
            GrammarBuilder recomendacion = new GrammarBuilder(choiceResultKey4);

            SemanticResultKey choiceResultKey5 = new SemanticResultKey("noPagar", noPagar);
            GrammarBuilder noPagar2 = new GrammarBuilder(choiceResultKey5);

            SemanticResultKey choiceResultKey6 = new SemanticResultKey("atras", "Atrás");
            GrammarBuilder ordenAtras = new GrammarBuilder(choiceResultKey6);

            SemanticResultKey choiceResultKey7 = new SemanticResultKey("recuentoTotal", "¿Cuánto dinero llevo?");
            GrammarBuilder recuentoTotal = new GrammarBuilder(choiceResultKey7);

            ///Construyendo las frases

            //Frase 1 ("Me apetece la 1")
            GrammarBuilder apetece = "Me apetece la";
            GrammarBuilder quiero = "Quiero la";
            Choices alternativas = new Choices(apetece, quiero);
            GrammarBuilder frase1 = new GrammarBuilder(alternativas);
            frase1.Append(opciones);

            //Frase 2 ("Me apetecen hamburguesas")
            GrammarBuilder apetece2 = "Me apetece";
            GrammarBuilder apetecen = "Me apetecen";
            Choices alternativas_2 = new Choices(apetecen, apetece);
            GrammarBuilder frase2 = new GrammarBuilder(alternativas_2);
            frase2.Append(menuPrincipal);

            //Frase 3 ("Cerrar")

            GrammarBuilder frase3 = cerrarExit;

            //Frase 4 ("¿Cuánto cuesta la 1?")
            GrammarBuilder cuantoCuesta = "Cuánto cuesta la";
            Choices alternativas_4 = new Choices(cuantoCuesta);
            GrammarBuilder frase4 = new GrammarBuilder(alternativas_4);
            frase4.Append(opciones);

            //Frase 5 ("¿Que me recomiendas?")
            GrammarBuilder frase5 = "Qué me";
            frase5.Append(recomendacion);

            //Frase 6 ("No voy a pagar")
            GrammarBuilder frase6 = "No";
            frase6.Append(noPagar2);
            GrammarBuilder pagar = "pagar";
            frase6.Append(pagar);

            //Frase 7 (Recuento total del pedido)
            GrammarBuilder frase7 = recuentoTotal;

            //Frase 8 (Atrás)
            GrammarBuilder frase8 = ordenAtras;

            ///Juntando todas las frases

            Choices alternativasGeneral = new Choices(frase1, frase2, frase3, frase4, frase5, frase6, frase7, frase8);
            GrammarBuilder fraseGeneral = new GrammarBuilder(alternativasGeneral);

            Grammar grammar = new Grammar(fraseGeneral);
            grammar.Name = "Pedir la cena";
            return grammar;
        }

    }
}
