import React from 'react';

const Counter = () => {
    [count, setCount] = setState(0);

    const updateCount = (change) => {
        var updatedValue = count + change;
        if(updatedValue >= 0){
            setCount(updatedValue);
        }
    }

    return (<View>
       <Text>{count}</Text> 
       <Button onPressed={updateCount(1)}>+</Button> 
       <Button onPressed={updateCount(-1)}>-</Button>
    </View>
    );
};

const GroceryItem = (item) => {
    return (<View>
        <CheckBox onPressed={removeItem(item)}/> <Input/> <Counter/>
        </View>
    );
};

const GroceryList = () => {
    [items, setItem] = setState([]);

    const removeItem = (item) => {
        //update state after removing item
    };

    const addItem = () => {
        //update state with added item
    };

    return (
        <View>
        <Text>Grocery List</Text>
        {items.map((item)=> <GroceryItem item={item} onRemove={removeItem}></GroceryItem>)}
        <Button onPressed={addItem}>+ Add Item</Button>
        </View>
    );
};

export default GroceryList;
