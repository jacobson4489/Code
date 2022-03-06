export class Address {
  public addressID: number;
  public address1: string;
  public address2?: string;
  public city: string;
  public state: string;
  public postalCode: string;
  public country: string;
  public isActive: boolean = true;
}
