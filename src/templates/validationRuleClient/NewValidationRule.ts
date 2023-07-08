import {
  ValidationRule,
  ValidationRuleProps,
} from "@kentico/xperience-admin-base";

interface NewValidationRuleProps extends ValidationRuleProps {
  readonly value: string;
}

export const NewValidationRule: ValidationRule<
  NewValidationRuleProps,
  string
> = (props, value) => {
  return { isValid: false, errorMessage: props.errorMessage };
};
