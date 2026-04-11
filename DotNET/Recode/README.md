# Record

레코드는 참조 형식 또는 값 형식으로 정의할 수 있으며, **형식 정의가 동일하고 모든 필드에 대해 두 레코드의 값이 같으면 레코드 형식의 두 변수가 동일**하다.  
참조된 개체가 동일한 클래스(Class) 형식이고 변수(Variable)가 동일한 개체를 참조하는 경우 클래스 형식의 두 변수가 동일하다. 값 기반 동등성은 레코드에서 요구하는 다른 기능을 읨미하며 컴파일러는 클래스 대신 레코드을 선언할 대 많은 멤버를 생성하기 때문에 `record struct`형식에 대해 동일한 메서드를 생성한다.

`record` 키워드를 사용하여 형식을 선언하고 `class`또는 `struct` 선언을 수정하여 레코드를 정의하여 필요에 따라 `class` 키워드를 생략하여 `record class`을 생성할 수 있다. 레코드는 값 기반 동등성 의미 체계를 따르기에 값에 대한 의미 체계를 적용하기 위해 컴파일러는 레코드 형식에 대한 여러 메서드를 생성한다.(`record class` or `record struct`)

```net
record class RecCS
{
    //...
}

class CS 
{
    record struct RecST
    {
        //...
    }
}
```

> [!NOTE]
> 해당 레코드는 다음과 같이 규칙이 적용된다.
> 1. Object.Equals(Object)우선 적용아다.
> 2. 매개 변수가 레코드 형식만 **Equals** 메소드이다.
> 3. Object.GetHashCode()에 대한 재정의이다.
> 4. `operator ==` 또는 `operator !=` 메서드 목록이다.
> 5. 레코드 형식은 `System.IEquatable<T>`을 구현한다.