import React, { ChangeEventHandler, useState } from "react";
import { FormComponentProps } from "@kentico/xperience-admin-base";
import { FormItemWrapper } from "@kentico/xperience-admin-components";

export interface NewFormComponentProps extends FormComponentProps {
  placeholderText: string;
}

export const NewFormComponent = (props: NewFormComponentProps) => {
  const handleOnChange: ChangeEventHandler = (value) => {
    if (props.onChange) {
      props.onChange(value);
    }
  };

  return (
    <FormItemWrapper
      label={props.label}
      explanationText={props.explanationText}
      invalid={props.invalid}
      validationMessage={props.validationMessage}
      markAsRequired={props.required}
      labelIcon={props.tooltip ? "xp-i-circle" : undefined}
      labelIconTooltip={props.tooltip}
    >
      <input
        value={props.value}
        onChange={handleOnChange}
        placeholder={props.placeholderText}
      />
    </FormItemWrapper>
  );
};
