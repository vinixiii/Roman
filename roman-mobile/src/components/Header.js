import React from "react";
import { StyleSheet, Text, View } from "react-native";

import { Logo } from "../assets/images/Logo";

export function Header() {
  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <Logo style={styles.logo} />
        <Text style={styles.headerText}>Olá, professor(a) Vinícius!</Text>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  header: {
    backgroundColor: "#fff",
    borderBottomLeftRadius: 6,
    borderBottomRightRadius: 6,
    paddingTop: 35,
    paddingBottom: 10,
    paddingLeft: 20,
    paddingRight: 20,
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",

    shadowColor: "#000",
    shadowOffset: {
      width: 0,
      height: 1,
    },
    shadowOpacity: 0.22,
    shadowRadius: 2.22,

    elevation: 3,
  },

  logo: {
    width: 40,
    height: 40,

    shadowColor: "#000",
    shadowOffset: {
      width: 0,
      height: 1,
    },
    shadowOpacity: 0.22,
    shadowRadius: 2.22,

    elevation: 3,
  },

  headerText: {
    fontSize: 16,
    color: "#7593b6",
  },
});
