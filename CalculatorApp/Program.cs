// See https://aka.ms/new-console-template for more information
using System;
using System.Data;

namespace CalculatorApp {
    abstract class Calculate {
        protected abstract void printHead(string arg);

        private void doCalculate(string sign="") {
            Console.Write("Enter your input in this format (1 + 2 + 4 . . .) >");
            string? input = Console.ReadLine();
            string line = input ?? null;
            if (string.IsNullOrEmpty(line)){
                Console.WriteLine("[Err]: An error occured while tryig to take input");
                return;
            }

            string[] lines= line.Split(sign);
            var result = 0;
            int num;
            foreach (string l in lines) {
                if (!int.TryParse(l, out num)) {
                    Console.WriteLine("Invalid input" + l);
                    continue;
                }

                result = num + result;
            }
            Console.WriteLine(result);
        }


        protected void doAllCalculate() {
            Console.Write("Enter your input in this format (1 + 2 + 4 . . .) >");
            string? input = Console.ReadLine();
            string line = input ?? null;
            if (string.IsNullOrEmpty(line)){
                Console.WriteLine("[Err]: An error occured while tryig to take input");
                return;
            }

            string value = new DataTable().Compute(line, null).ToString();
            
            Console.WriteLine(value);
        }

        public void addition() {
            Console.WriteLine(new string('\n', 10));
            printHead("ADDITIONS");

            doAllCalculate();
            // doCalculate("+");

            // implement addition logic
        }
    }

    class Program : Calculate {
        private List<string> operations = ["addition", "subtraction", "multiplication", "division"];

        private void printNow(string? arg = "\n") {
            Console.Write(arg);
            Console.WriteLine("Available Options: ");
            foreach (string op in operations) {
                Console.Write($"{operations.IndexOf(op)}. ");
                Console.WriteLine(char.ToUpper(op[0]) + op.Substring(1));
            }
        }

        protected override void printHead(string arg = "") {
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
                // switch (response) {
                //     case "addition":
                //         program.addition();
                //         break;
                // }
                program.doAllCalculate();
            }
        }
    }
}

