import java.util.Scanner;

class _01_Rectangle_Area {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double a = scanner.nextDouble();
        double b = scanner.nextDouble();
        System.out.printf("%.2f", a * b);
        scanner.close();
    }
}