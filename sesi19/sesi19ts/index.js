console.log("hello kawan");
const alex = {
    name: 'Alexander',
    age: 21,
    isActive: true,
    otherData: ['Peserta FSD OCBC Batch 3']
};
console.log(alex);
;
//class <namaClass> [extends <NamaParentClass>] [implements <NamaInterface>]
class Participant {
    // name = '';
    // age = 0;
    // isActive = true;
    // otherData = '' ;
    constructor(name, age, isActive, otherData) {
        this.name = name;
        this.age = age;
        this.isActive = isActive;
        this.otherData = otherData;
    }
}
const edward = new Participant('Edward', 21, true, []);
