1 number............pointer..example..

#include <stdio.h>

int main()
{
    
  int a = 10;
  int *p; //deaclear pointer like a integer

  p = &a;

  printf("\n\nvalu of a is : %d \n\n", a);
  printf("address of a is: %d\n\n", &a);
  printf("valu of p is : %d\n\n", p);
  printf("pointer value rafer of x : %d\n\n", *p);
  printf("pointer address : %d\n\n", &p);

    return 0;
}

02 ...number  ...array diclaration.........

#include <stdio.h>

int main()
{
  // array declaration

  int a[]={10,20,30,40,50};
  for(int i=0; i<5; i++){

    printf("a[%d] = [%d]\n", i, a[i]);
  }

    return 0;
}

03 there are use function 

#include<stdio.h>
 int get_sum(int x, int y){ //user define  function
    
    int sum = x + y;
    return sum;
}
void even_or_odd(int x){
    if(x % 2 == 0){
        printf("EVEN\n");
    }else{
        printf("ODD\n");
    }

}
void print_devisors(int x){
    int i;
    for(i= 1; i <= x; i++){
        if(x % i = 0){
            printf("%d\n", i);
        }
    }
}

int add_result(int a, int b){
    return a+b;
}

int subtruct_result(int a, int b){
    return a-b;
}

int maltiplay_result(int a, int b){
    return a*b;
}

int devisore_result(int a, int b){
    return a/b;
}

int main(){ // main function


int result = get_sum(10, 20);
printf("result = %d\n", result);
even_or_odd(10);
print_devisors(20);

//return function
int a, b;
printf("inpute the number");
scanf("%d %d", &a, &b);

int result1 = add_result(a, b);
int result2 = subtruct_result(a, b);
int result3 = maltiplay_result(a, b);
int result4 = devisore_result(a, b);
printf("add = %d, subtruct = %d\n, multiplay = %d\n, devidore =  %d\n", result1, result2, result3, result4);

return 0;

}

04 the structure

#include<stdio.h>
struct student{
    int id;
    char name[10];
    float cgpa;
};

int main(){ // main function

//there are use structure

struct student s;
printf("Enter your id: \n");
scanf("%d", &s.id);
printf("Enter your name: \n");
scanf("%s", s.name);
printf("Enter your cgpa: \n");
scanf("%f", &s.cgpa);
printf("id: %d\n name: %s\n cgpa:%f", s.id, s.name, s.cgpa);

return 0;
}

05 pointer 

#include <stdio.h>

int main(){

int x = 10;
int *p = &x;
printf("value of x:%d,  value if pointer: %d, value of p: %d, address of x:%d", x, *p, p, &x);

return 0;
}
 
06 malloc, calloc, free, realloc with pointer

#include <stdio.h>
#include <stdlib.h>

int main(){
//dinamic memory allocarion
//function of malloc(), calloc(), free(), realloc(); 
//with pointer 
//library file #include <stdlib.h>
int *ptr;
// ptr = (int *)malloc(5 * sizeof(int));
// ptr = (int *)calloc(5,sizeof(int));

if(ptr == NULL){
    printf("Memory not allocated");
}else{
    printf("Memory allocated successfully\n");
    //free memory
    free(ptr);
    printf("memory free successfully\n");
}

int *ptr1, *ptr2;

ptr1 = (int *)malloc(20);
ptr2 = (int*)calloc(5, sizeof(int));
if(ptr1 == NULL || ptr2 == NULL){
    printf("Memory not allocated");
}else{
    printf("Memory allocated successfully\n");
    //realloc
    ptr1 = realloc(ptr1, 50);    
    printf("Memory reallocation successfully.\n");
}
return 0;
}
