/*
INTRODUCTION

Your program is to use the brute-force approach in order to find the Answer to Life, the Universe, 
and Everything. More precisely... rewrite small numbers from input to output. 
Stop processing input after reading in the number 42. All numbers at input are integers of one or two digits.

Example
Input:
1
2
88
42
99

Output:
1
2
88

SOLUTION
The Objective here is simply create a code where the user can type any number UNTIL type 42, at this point the program stop
Code in c#
*/

main();
int main(){
    int input;
    while (input != 42){
        scanf("%i", &input);
        if (input != 42){
            printf("%i\n", input);
            }
            }
return 0;
}
