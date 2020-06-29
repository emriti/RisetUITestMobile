import React, {Component} from 'react';
import {View, Text, Button} from 'react-native';

export default class App extends Component {
  constructor() {
    super();

    this.onRed = this.onRed.bind(this);
    this.onBlue = this.onBlue.bind(this);
    this.onGreen = this.onGreen.bind(this);

    this.state = {backgroundColor: '#FFFFFF'};
  }

  onRed() {
    this.setState({backgroundColor: '#FF0000'});
    console.log(this.state);
  }

  onBlue() {
    this.setState({backgroundColor: '#0000FF'});
    console.log(this.state);
  }

  onGreen() {
    this.setState({backgroundColor: '#00FF00'});
    console.log(this.state);
  }

  render() {
    return (
      <View style={{backgroundColor: this.state.backgroundColor}}>
        <Text>Hello, I am your cat!</Text>
        <Button onPress={this.onRed} title="Red" accessibilityLabel="Red"  />
        <Button onPress={this.onBlue} title="Blue" accessibilityLabel="Blue" />
        <Button
          onPress={this.onGreen}
          title="Green"
          accessibilityLabel="Green"
        />
      </View>
    );
  }
}
