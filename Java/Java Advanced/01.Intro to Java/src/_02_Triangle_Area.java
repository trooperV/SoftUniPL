import java.util.Scanner;

class _02_Triangle_Area {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int ax = scanner.nextInt();
        int ay = scanner.nextInt();
        int bx = scanner.nextInt();
        int by = scanner.nextInt();
        int cx = scanner.nextInt();
        int cy = scanner.nextInt();

        System.out.print(Math.abs((ax * (by - cy) + bx * (cy - ay) + cx * (ay - by)) / 2));

        scanner.close();
    }
}