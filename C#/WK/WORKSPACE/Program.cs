
DoOp(10,5,add);
cacl mk = add;
Console.WriteLine(mk(5, 8));

 void DoOp(int x, int y, cacl op) => Console.WriteLine(op(x, y));
int substract(int x, int y) => x * y;
int add(int x, int y) => x + y;
delegate int cacl(int x,int y);