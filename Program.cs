// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class KodeProduk {
    public enum Produk {
        Laptop,
        Smartphone,
        Tablet,
        Headset,
        Keyboard,
        Mouse,
        Printer,
        Monitor,
        Smartwatch,
        Kamera
    }

    private static string[] kodproduk = { "E100", "E101" , "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109"};

    public static string getKodeProduk(Produk elektronik) {
        return kodproduk[(int) elektronik];
    }

    internal class FanLaptop
    {
        public enum FanState { Quite, Balance, Performance, Turbo }
        public enum Trigger { modeDown, modeUp, turboShortcut }

        class Transition
        {
            public FanState prevstate;
            public FanState nextstate;
            public Trigger trigger;
            public Transition(FanState prevstate, FanState nextstate, Trigger trigger)
            {
                this.prevstate = prevstate;
                this.nextstate = nextstate;
                this.trigger = trigger;
            }

            private FanState currentState;
            public FanLaptop()
            {
                currentState = FanState.Quite;
            }

            public static List<Transition>transitions = new List<Transition>
            {
                new Transition(FanState.Quite, FanState.Balance, Trigger.modeUp),
                new Transition(FanState.Quite, FanState.Turbo, Trigger.turboShortcut),
                new Transition(FanState.Balance, FanState.Quite, Trigger.modeDown),
                new Transition(FanState.Balance, FanState.Performance, Trigger.modeUp),
                new Transition(FanState.Performance, FanState.Balance, Trigger.modeDown),
                new Transition(FanState.Performance, FanState.Turbo, Trigger.modeUp),
                new Transition(FanState.Turbo, FanState.Performance, Trigger.modeDown),
                new Transition(FanState.Turbo, FanState.Quite, Trigger.turboShortcut),
            };

            public FanState GetNextState(FanState prevstate, FanState nextstate, Trigger trigger)
            {
                foreach (var transition in transition)
                {
                    if (transition.prevstate == prevstate && transition.trigger == trigger)
                    {
                        return transition.currentState;
                    }
                    return prevstate;
                }
                Public void ActiveTrigger(Trigger trigger)
                {
                    FanState nextState = GetNextState(currentState, trigger);
                    if (nextState != currentState)
                    {
                        currentState = nextState;
                        Console.WriteLine(nextState == FanState.Quite ? "Fan quite berubah menjadi turbo")
                    }
                }
            }
        }
    }



    public static void Main()
    {
        Console.WriteLine("kode produk Laptop: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Laptop));
        Console.WriteLine("kode produk Smartphone: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Smartphone));
        Console.WriteLine("kode produk Tablet: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Tablet));
        Console.WriteLine("kode produk Headset: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Headset));
        Console.WriteLine("kode produk Keyboard: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Keyboard));
        Console.WriteLine("kode produk Mouse: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Mouse));
        Console.WriteLine("kode produk Printer: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Printer));
        Console.WriteLine("kode produk Monitor: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Monitor));
        Console.WriteLine("kode produk Smartwatch: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Smartwatch));
        Console.WriteLine("kode produk Kamera: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Kamera));

        FanLaptop fan = new FanLaptop();
        while (true) {
            Console.WriteLine("Masukkan perintah(modeDown/mopdeUp/turboshortcut): ");
            string input = Console.ReadLine().ToLower();

            if (input == "modeUp") {
                fan.ActivateTrigger(Trigger)
            }
        }

    }

}


