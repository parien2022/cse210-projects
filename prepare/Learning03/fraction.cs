public class Fraction{


    private float _top;
    private float _bottom;


    public void SetFraction (){

        _top = 1;
        _bottom = 1;
    }

    public void setFraction2 (int top){

        _top = top;
        _bottom = 1;
    }


    public void setFraction3 (int top, int bottom){

        _top = top;
        _bottom = bottom;
    }

     public float GetTop (){
        return _top;
    }

     public float GetBottom (){
        return _bottom;
    }

    public String GetFractionString (){
        return _top + "/" + _bottom;
    }

    public Double GetDecimalValue (){
        return _top / _bottom;
    }

   
}