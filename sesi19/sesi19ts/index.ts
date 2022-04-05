console.log("hello kawan");

type TPerson = {

    name: string
    age: number
    isActive: boolean

    //type union
    otherData: string[] | string


    //optional properties
    score?: number
};

const alex: TPerson = {
    name: 'Alexander',
    age: 21,
    isActive: true,
    otherData: ['Peserta FSD OCBC Batch 3']
};
console.log(alex)

//interface
interface IPerson  {

    name: string
    age: number
    isActive: boolean

    //type union
    otherData: string[] | string


    //optional properties
    score?: number
};


//class <namaClass> [extends <NamaParentClass>] [implements <NamaInterface>]
class Participant implements IPerson{
    // name = '';
    // age = 0;
    // isActive = true;
    // otherData = '' ;

    constructor(public name,public age,public isActive,public otherData){

    }
}

const edward = new Participant('Edward', 21, true, []);