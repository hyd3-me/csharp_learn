
// задача 1

System.Console.WriteLine("введите количество элементов массива: ");
int length = int.Parse(System.Console.ReadLine());

int[] inputArray(int length) {
    int[] array = new int[length];
    for (int i = 0; i < length; i++) {
        System.Console.WriteLine($"введите {i + 1}-й элемент: ");
        array[i] = int.Parse(System.Console.ReadLine());
    }
    return array;
}

int[] array = inputArray(length);

System.Console.WriteLine($"готовый массив: [{string.Join(", ", array)}]");

int CountPositivNumbers(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) {
            count++;
        }
    }
    return count;
}

int pos_nums = CountPositivNumbers(array);

System.Console.WriteLine($"количество чисел больше 0: {pos_nums}");


// задача 2

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2)) {
    double[] coord = FindCoords(lineData1, lineData2);
    System.Console.Write($"точка пересечения уравнений у={lineData1[COEFFICIENT]}*x+{lineData1[CONSTANT]} и у={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]} ");
    System.Console.WriteLine($" имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
}

double Prompt(string message) {
    System.Console.Write(message);
    string value = System.Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine) {
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"введите коэффициент для {numberOfLine} прямой: ");
    lineData[CONSTANT] = Prompt($"введите константу для {numberOfLine} прямой: ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2) {
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2) {
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT]) {
        if (lineData1[CONSTANT] == lineData2[CONSTANT]) {
            System.Console.WriteLine("прямые совпадают");
            return false;
        } else {
            System.Console.WriteLine("прямые параллельны");
            return false;
        }
    }
    return true;
}