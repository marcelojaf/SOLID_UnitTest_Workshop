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
        return
        <h1>
          Sum of the areas of provided shapes:
             ${this.sum()}
        </h1>
      }
    }
    return Object.assign(Object.create(proto), { shapes: s })
  }
  
  

  
  const shapes = [
    circle(2),
    square(5),
    square(6)
  ]
  const areas = areaCalculator(shapes)
  console.log(areas.output())