internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();
        program.simpleCalculate(args);
    }
    public void simpleCalculate(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Для использовани приложения введите 3 аргумента" +
                "операнд1 операция операнд2");
        }
        else
        {
            double op1 = 0;
            double op2 = 0;
            string op3 = "";
            try
            {
                op1 = double.Parse(args[0]);
                op2 = double.Parse(args[2]);
                op3 = args[1];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            switch (op3)
            {
                case "+":
                    Console.WriteLine(op1 + op2);
                    break;
                case "-":
                    Console.WriteLine(op1 - op2);
                    break;
                case "*":
                    Console.WriteLine(op1 * op2);
                    break;
                case "/":
                    if (op2 == 0)
                    {
                        Console.WriteLine("Деление на 0 невозможно");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(op1 / op2);
                        break;
                    }
                default:
                    Console.WriteLine("Операция не найдена, используйте " +
                        "+ - * /");
                    break;
            }
        }
    }

}
