using System;
using AtomicEngine;
using System.Linq;

public class ArrayTest : CSComponent
{

    [Inspector]
    bool[] MyBoolArray;

    [Inspector]
    int[] MyIntArray;

    [Inspector]
    float[] MyFloatArray;

    [Inspector]
    string[] MyStringArray;

    [Inspector]
    Color[] MyColorArray;

    [Inspector]
    Vector2[] MyVector2Array;

    [Inspector]
    Vector3[] MyVector3Array;

    bool[] CheckBoolArray;

    int[] CheckIntArray;

    float[] CheckFloatArray;

    string[] CheckStringArray;

    Color[] CheckColorArray;

    Vector2[] CheckVector2Array;

    Vector3[] CheckVector3Array;

    // TODO resource/node arrays

    void Start()
    {
        CheckBoolArray = new bool[4];
        CheckBoolArray[0] = true;
        CheckBoolArray[1] = false;
        CheckBoolArray[2] = true;
        CheckBoolArray[3] = true;

        CheckIntArray = new int[5];
        CheckIntArray[0] = 5;
        CheckIntArray[1] = 4;
        CheckIntArray[2] = 3;
        CheckIntArray[3] = 2;
        CheckIntArray[4] = 1;

        CheckFloatArray = new float[6];
        CheckFloatArray[0] = 6.1f;
        CheckFloatArray[1] = 5.2f;
        CheckFloatArray[2] = 4.3f;
        CheckFloatArray[3] = 10.0f;
        CheckFloatArray[4] = 15.0f;
        CheckFloatArray[5] = 50.0f;

        CheckStringArray = new string[4];
        CheckStringArray[0] = "Welcome";
        CheckStringArray[1] = "to";
        CheckStringArray[2] = "the";
        CheckStringArray[3] = "Vector Inspector!";

        CheckColorArray = new Color[2];
        CheckColorArray[0] = new Color(1, 1, 0, 1);
        CheckColorArray[1] = new Color(1, 0, 1, 1);

        CheckVector2Array = new Vector2[2];
        CheckVector2Array[0] = new Vector2(4, 3);
        CheckVector2Array[1] = new Vector2(2, 1);

        CheckVector3Array = new Vector3[2];
        CheckVector3Array[0] = new Vector3(1, 2, 3);
        CheckVector3Array[1] = new Vector3(6, 5, 4);

    }

    void Update(float timeStep)
    {
        if (!MyBoolArray.SequenceEqual(CheckBoolArray))
            Error();

        if (!MyIntArray.SequenceEqual(CheckIntArray))
            Error();

        if (!MyFloatArray.SequenceEqual(CheckFloatArray))
            Error();

        if (!MyStringArray.SequenceEqual(CheckStringArray))
            Error();

        if (!MyColorArray.SequenceEqual(CheckColorArray))
            Error();

        if (!MyVector2Array.SequenceEqual(CheckVector2Array))
            Error();

        if (!MyVector3Array.SequenceEqual(CheckVector3Array))
            Error();
    }

    void Error()
    {
        throw new Exception("Mismatch in array data");
    }

}

// From scene for validity check
/*
			<attribute name="FieldValues">
				<variant hash="3926622883" type="VariantVector">
					<variant type="Bool" value="true" />
					<variant type="Bool" value="false" />
					<variant type="Bool" value="true" />
					<variant type="Bool" value="true" />
				</variant>
				<variant hash="3943230166" type="VariantVector">
					<variant type="Int" value="5" />
					<variant type="Int" value="4" />
					<variant type="Int" value="3" />
					<variant type="Int" value="2" />
					<variant type="Int" value="1" />
				</variant>
				<variant hash="1586339913" type="VariantVector">
					<variant type="Float" value="6.1" />
					<variant type="Float" value="5.2" />
					<variant type="Float" value="4.3" />
					<variant type="Float" value="10" />
					<variant type="Float" value="15" />
					<variant type="Float" value="50" />
				</variant>
				<variant hash="1688323810" type="VariantVector">
					<variant type="Color" value="1 1 0 1" />
					<variant type="Color" value="1 0 1 1" />
				</variant>
				<variant hash="1135402966" type="VariantVector">
					<variant type="Vector2" value="4 3" />
					<variant type="Vector2" value="2 1" />
				</variant>
				<variant hash="1507410197" type="VariantVector">
					<variant type="Vector3" value="1 2 3" />
					<variant type="Vector3" value="6 5 4" />
				</variant>
				<variant hash="1024728828" type="VariantVector">
					<variant type="String" value="Welcome" />
					<variant type="String" value="to" />
					<variant type="String" value="the" />
					<variant type="String" value="Vector Inspector!" />
				</variant>
			</attribute>
 * 
*/