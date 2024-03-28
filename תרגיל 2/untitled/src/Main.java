import java.util.Scanner;

public class Main {


    public static void printOfTwoer(int option) {

    }


    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int height, weight, option, opt_tri;
        System.out.println("if twoer is square insert 1, if is triangular insert 2, if you want to finish insert 3.");
        option = in.nextInt();
        while (option != 3) {
            System.out.println("insert height");
            height = in.nextInt();
            System.out.println("insert weight");
            weight = in.nextInt();
            if (option == 1) {
                if (height == weight || Math.max(height, weight) - Math.min(height, weight) > 5) {
                    System.out.println("area: " + (weight * height));
                } else {
                    System.out.println("scope: " + ((weight * 2) + (height * 2)));
                }
            } else {
                System.out.println("if you wont to print the scope of tower insert 1, if you wont to print the tower insert2");
                opt_tri = in.nextInt();
                if (opt_tri == 1) {
                    double yeter = (height * height) + ((weight / 2) * (weight / 2));
                    yeter = Math.sqrt(yeter);
                    System.out.println("scope: " + (weight + (yeter * 2)));
                } else {
                    if (height == 3 && weight == 3) {
                        System.out.println(" *");
                        System.out.println(" *");
                        System.out.println("***");
                    }
                    else if (height==2&&weight==3){
                        System.out.println(" *");
                        System.out.println("***");
                    }
                    else {
                        if (weight % 2 == 0 || (weight > (height * 2))) {
                            System.out.println("The tower cannot be printed");
                        } else {
                            System.out.println("print the tower:");
                            int temp_h = height - 2, sum_floors = (weight - 2) / 2, every_floor = temp_h / sum_floors, second_floor = every_floor + (temp_h - (sum_floors * every_floor));
                            int cnt = 1, star = 3,space=weight/2;
                            for (int i = 0; i <space ; i++) {
                                System.out.print(" ");
                            }
                            System.out.println("*");
                            cnt++;
                            while (cnt < height) {
                                if (cnt == 2) {

                                    for (int i = 0; i < second_floor; i++) {
                                        space=(weight/2)-(star/2);
                                        for (int j = 0; j <space ; j++) {
                                            System.out.print(" ");
                                        }
                                        System.out.println("***");
                                        cnt++;
                                    }
                                } else {
                                    for (int i = 0; i < every_floor; i++) {
                                        space=(weight/2)-(star/2);
                                        for (int k = 0; k <space ; k++) {
                                            System.out.print(" ");
                                        }
                                        for (int j = 0; j < star; j++) {
                                            System.out.print("*");
                                        }
                                        System.out.println();
                                        cnt++;
                                    }
                                }
                                star += 2;
                            }
                            for (int i = 0; i < weight; i++) {
                                System.out.print("*");
                            }
                            System.out.println();
                        }
                    }
                }
            }
            System.out.println("if twoer is square insert 1, if is triangular insert 2, if you want to finish insert 3.");
            option = in.nextInt();
        }
        System.out.println("you wonted to exit");
    }
}