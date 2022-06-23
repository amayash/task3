import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Scanner;
import arrays.*;

public class Array extends JFrame {
    Array() {
        super();
        setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        JPanel panel = new JPanel();
		panel.setBackground(Color.yellow);
        panel.setLayout(new BorderLayout());
        JPanel buttonPanel = new JPanel();
        buttonPanel.setLayout(new GridBagLayout());
        GridBagConstraints constraints = new GridBagConstraints();

        constraints.gridy = 0;
        constraints.gridx = 1;
        JTextField odnom = new JTextField(5);
        buttonPanel.add(odnom, constraints);

        constraints.gridx = 2;
        JButton firstArrayButton = new JButton("1мерный");
        buttonPanel.add(firstArrayButton, constraints);

        constraints.gridy = 1;
        constraints.gridx = 0;
        JTextField dvumi = new JTextField(5);
        buttonPanel.add(dvumi, constraints);

        constraints.gridx = 1;
        JTextField dvumj = new JTextField(5);
        buttonPanel.add(dvumj, constraints);

        constraints.gridx = 2;
        JButton secondArrayButton = new JButton("2мерный");
        buttonPanel.add(secondArrayButton, constraints);

        panel.add(buttonPanel, BorderLayout.SOUTH);

        JLabel original = new JLabel();
		original.setHorizontalAlignment(JLabel.CENTER);
        panel.add(original, BorderLayout.NORTH);
        JLabel firstTask = new JLabel();
        panel.add(firstTask, BorderLayout.WEST);
        JLabel secondTask = new JLabel();
		secondTask.setHorizontalAlignment(JLabel.CENTER);
        panel.add(secondTask, BorderLayout.CENTER);


        firstArrayButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    String Text;
                    Array_first a1 = new Array_first(Integer.parseInt(odnom.getText()));
                    Text = "<html>Оригинальный массив<br>" + a1.Print() + "<br></html>";
                    original.setText(Text);


                    String firstText;
                    firstText = "<html>Первое задание<br>" + a1.nom1() + "</html>";
                    firstTask.setText(firstText);

                    secondTask.setText("");
                }
                catch (Exception n) {
                    System.exit(0);
                }
            }
        });

        secondArrayButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
				String Text;
				Array_second a2 = new Array_second(Integer.parseInt(dvumi.getText()),
				Integer.parseInt(dvumj.getText()));
				Text = "<html>Оригинальный массив<br>";
				Text = Text +a2.Print()+"<br>";
				Text = Text + "</html>";
				original.setText(Text);
				String firstText;
				
				firstText = "<html>Второе задание<br>";
				firstText = firstText + a2.nom2() + "<br>";
				firstText = firstText + "</html>";
				firstTask.setText(firstText);
				
				String secondText;
				secondText = "<html>Третье задание<br>";
				secondText = secondText + a2.nom3(a2.stroka()) + "<br>";
				secondText = secondText + "</html>";
				secondTask.setText(secondText);
                }
            });

        getContentPane().add(panel);
    }

    public static void main(String[] args) {
        JFrame.setDefaultLookAndFeelDecorated(true);
        Array win = new Array();
        win.pack();
        win.setSize(700, 500);
        win.setLocationRelativeTo(null);
        win.setVisible(true);
    }

}
