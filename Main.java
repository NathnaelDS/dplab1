public class Main {

    public static void main(String[] args) {
//COMMAND LINE PROCESSING
        for (int i = 0; i <  args.length; i++) {
            System.out.println("Arg " + i + " : " + args[i]);
        }

        int[] arrayOfIntegers = new int[9];
// TRY CATCH FINALLY
        try {
            int i = arrayOfIntegers[9];
            System.out.println(i);
        } catch (ArrayIndexOutOfBoundsException e) {
            System.out.println("Exception: Array Probs");
        } finally {
            System.out.println("Finally: Usually clear stuff up here");
        }

        Octagon o = new Octagon();
        o.getInfo("8");
    }
}

abstract class Shape {
    abstract void draw();

    void getInfo(){
        System.out.println("Tis a shape");
    }
}

class Octagon extends Shape {
    @Override
    void draw() {
        System.out.println("__OCTAGON__");
    }
//OVERLOADING
    void getInfo(String sides) {
        System.out.println("this shape has " + sides + " sides");
    }
}