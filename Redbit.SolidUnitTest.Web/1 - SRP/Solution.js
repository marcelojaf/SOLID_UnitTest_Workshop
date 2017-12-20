const circle = (radius) => {
  const proto = {
    type: 'Circle',

    //...code
  }
}

const square = (length) => {
  const proto = {
    type: 'Square',

    //...code
  }
}

const areaCalculator = (s) => {
  const proto = {
    sum() {
      // logic to sum
    },
    output() {
      return this.sum()
    }
  }
  return Object.assign(Object.create(proto), { shapes: s })
}

const areaCalculatorOutputter = (area) => {
  const proto = {
    JSON() {
      //json format
    },
    HTML() {
      //html format
    },
    XML() {
      //xml format
    }
  }
}





const shapes = [
  circle(2),
  square(5),
  square(6)
]
const areas = areaCalculator(shapes)
const output = sumCalculatorOputter(areas)
console.log(output.JSON())
console.log(output.HTML())
console.log(output.XML())