// See https://aka.ms/new-console-template for more information
using System;

namespace CalculatorApp {
    class Program {
        List<string> operations = ["addition", "subtraction", "multiplication", "division"];

        private void printNow(string? arg = "\n") {
            Console.Write(arg);
            foreach (string op in operations) {
                Console.Write($"{operations.IndexOf(op)}. ");
                Console.WriteLine(char.ToUpper(op[0]) + op.Substring(1));
            }
        }

        private void printHead(string arg = "") {
            string equalsTo = new string('=' , 80);
            Console.WriteLine($"{equalsTo}\n{arg}\n{equalsTo}");
        }

        private string? Ask (string arg) {
            Console.Write($"{arg} > ");
            return Console.ReadLine();
        }

        static void Main (string[] args) {
            // call the method for printing
            Program program = new Program();
            program.printHead("WELCOME TO CALCULATOR");
            while (true) {
                program.printNow();
                string? response = program.Ask("[Command]");
                if (string.IsNullOrEmpty(response)) continue;

                if (!program.operations.Contains(response.ToLower())) {
                    int responseNumber;
                    if (!int.TryParse(response, out responseNumber)) {
                        Console.WriteLine("[Err]: Unrecognized input");
                        continue;
                    }
                    if (responseNumber > (program.operations.Count() - 1) || responseNumber < 0) {
                        Console.WriteLine("[Err]: Out of range");
                        continue;
                    }
                    response = program.operations[responseNumber];
                }
                
                // switch statement to process calculation
                switch (response) {
                    case "addtion":
                        // case for addition
                        break;
                }
            }
        }
    }
}

