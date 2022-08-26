import React, {useState} from 'react';
import {View, Text} from 'react-native';
import Button from 'CatalystPortalMobile/src/components/button';

import StringComponent from 'CatalystPortalMobile/src/components/form/string';
import TextComponent from 'CatalystPortalMobile/src/components/form/text';
import BoolComponent from 'CatalystPortalMobile/src/components/form/bool';
import TokenInputComponent from 'CatalystPortalMobile/src/components/form/token-input';
import SelectorComponent from 'CatalystPortalMobile/src/components/form/selector';

export const COMPONENTS = {
  string: StringComponent,
  text: TextComponent,
  boolean: BoolComponent,
  select_tag: SelectorComponent,
  subregion_select: SelectorComponent,
  country_select: SelectorComponent,
  token_input: TokenInputComponent,
};

const Field = ({type, label, name, ...props}) => {
  const FieldComponent = COMPONENTS[type] || StringComponent;

  return (
    <View>
      <Text accessibilityLabel={label}>
        {props.required ? (
          <Text>*</Text>
        ) : null}
        {label}
      </Text>
      <FieldComponent
        {...props}
      />
    </View>
  );
};

const Form = ({
  onChange = () => {},
  onSubmit = () => {},
}) => {
  const [field_values, setFieldValues] = useState([]);

  const handleSubmit = (e) => {
    e.preventDefault();
    e.stopPropagation();
    onSubmit(field_values);
  };

  const handleChange = (name, value) => {
    const _field_values = JSON.parse(JSON.stringify(field_values));
    _field_values[name] = value;
    
    setFieldValues(_field_values);
    onChange(_field_values);
  };

  return (
    <View onSubmit={handleSubmit}>
      {Object.values(field_values).map(
        ({label, name, data, type = 'text', obj, ...field}, i, a) => (
          <Field
            key={name}
            name={name}
            type={type}
            label={label}
            value={data}
            allValues={field_values}
            index={i}
            count={a.length}
            {...field}
            onChange={handleChange}
          />
        )
      )}
      <Button
        onPress={handleSubmit}
        text={'Submit'}
      />
    </View>
  );
};

export default Form;
