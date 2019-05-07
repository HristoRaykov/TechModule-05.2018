<?php

/* calculator/index.html.twig */
class __TwigTemplate_b42e924e868d0e0b9f6a10cc5a0a44b7692ae2bf5cece60b210ba163eb491645 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "calculator/index.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_d308d6e73891a1ab0f690ee7dcc904d19ebf35a97713be84ea2bfc3de7c3f1bd = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d308d6e73891a1ab0f690ee7dcc904d19ebf35a97713be84ea2bfc3de7c3f1bd->enter($__internal_d308d6e73891a1ab0f690ee7dcc904d19ebf35a97713be84ea2bfc3de7c3f1bd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "calculator/index.html.twig"));

        $__internal_96354427d18118c9638b492489eca0b96ffd80cd738f0fdbc3c5c0c458d23470 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_96354427d18118c9638b492489eca0b96ffd80cd738f0fdbc3c5c0c458d23470->enter($__internal_96354427d18118c9638b492489eca0b96ffd80cd738f0fdbc3c5c0c458d23470_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "calculator/index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_d308d6e73891a1ab0f690ee7dcc904d19ebf35a97713be84ea2bfc3de7c3f1bd->leave($__internal_d308d6e73891a1ab0f690ee7dcc904d19ebf35a97713be84ea2bfc3de7c3f1bd_prof);

        
        $__internal_96354427d18118c9638b492489eca0b96ffd80cd738f0fdbc3c5c0c458d23470->leave($__internal_96354427d18118c9638b492489eca0b96ffd80cd738f0fdbc3c5c0c458d23470_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_41a53959aa01a879cf77199d07564358385080b3d744f5a8142556888afc37b5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_41a53959aa01a879cf77199d07564358385080b3d744f5a8142556888afc37b5->enter($__internal_41a53959aa01a879cf77199d07564358385080b3d744f5a8142556888afc37b5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_265d241ea7a0e936cb180d784b2745c31ebea847f7a9f315f42f0c8952ff6516 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_265d241ea7a0e936cb180d784b2745c31ebea847f7a9f315f42f0c8952ff6516->enter($__internal_265d241ea7a0e936cb180d784b2745c31ebea847f7a9f315f42f0c8952ff6516_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div class=\"container body-content span=8 offset=2\">
        <div class=\"well\">
            <form class=\"form-inline\" action=\"";
        // line 6
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" method=\"POST\">
                <fieldset>
                    <div class=\"form-group\">
                        <div class=\"col-sm-1 \">
                            <input type=\"text\" class=\"form-control\" id=\"leftOperand\" placeholder=\"Left Operand\"
                                   name=\"calculator[leftOperand]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, ((($this->getAttribute(($context["calculator"] ?? null), "leftOperand", array(), "any", true, true) &&  !(null === $this->getAttribute(($context["calculator"] ?? null), "leftOperand", array())))) ? ($this->getAttribute(($context["calculator"] ?? null), "leftOperand", array())) : ("")), "html", null, true);
        echo "\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <select class=\"form-control\" name=\"calculator[operator]\">
                                <option value=\"+\" ";
        // line 18
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "+"))) ? ("selected") : (""));
        echo ">+</option>
                                <option value=\"-\" ";
        // line 19
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "-"))) ? ("selected") : (""));
        echo ">-</option>
                                <option value=\"*\" ";
        // line 20
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "*"))) ? ("selected") : (""));
        echo ">*</option>
                                <option value=\"/\" ";
        // line 21
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "/"))) ? ("selected") : (""));
        echo ">/</option>
                                <option value=\"^\" ";
        // line 22
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute(($context["calculator"] ?? $this->getContext($context, "calculator")), "operator", array()) == "^"))) ? ("selected") : (""));
        echo ">^</option>
                            </select>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"rightOperand\" placeholder=\"Right Operand\"
                                   name=\"calculator[rightOperand]\" value=\"";
        // line 30
        echo twig_escape_filter($this->env, ((($this->getAttribute(($context["calculator"] ?? null), "rightOperand", array(), "any", true, true) &&  !(null === $this->getAttribute(($context["calculator"] ?? null), "rightOperand", array())))) ? ($this->getAttribute(($context["calculator"] ?? null), "rightOperand", array())) : ("")), "html", null, true);
        echo "\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-2 \">
                            <p>=</p>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"result\" placeholder=\"Result\"
                                   name=\"result\" value=\"";
        // line 43
        echo twig_escape_filter($this->env, (($context["result"]) ?? ("")), "html", null, true);
        echo "\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 col-sm-offset-4\">
                            <button type=\"submit\" class=\"btn btn-primary\">Calculate</button>
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
    </div>
";
        
        $__internal_265d241ea7a0e936cb180d784b2745c31ebea847f7a9f315f42f0c8952ff6516->leave($__internal_265d241ea7a0e936cb180d784b2745c31ebea847f7a9f315f42f0c8952ff6516_prof);

        
        $__internal_41a53959aa01a879cf77199d07564358385080b3d744f5a8142556888afc37b5->leave($__internal_41a53959aa01a879cf77199d07564358385080b3d744f5a8142556888afc37b5_prof);

    }

    public function getTemplateName()
    {
        return "calculator/index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  114 => 43,  98 => 30,  87 => 22,  83 => 21,  79 => 20,  75 => 19,  71 => 18,  61 => 11,  53 => 6,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends 'base.html.twig' %}

{% block main %}
    <div class=\"container body-content span=8 offset=2\">
        <div class=\"well\">
            <form class=\"form-inline\" action=\"{{ path('index') }}\" method=\"POST\">
                <fieldset>
                    <div class=\"form-group\">
                        <div class=\"col-sm-1 \">
                            <input type=\"text\" class=\"form-control\" id=\"leftOperand\" placeholder=\"Left Operand\"
                                   name=\"calculator[leftOperand]\" value=\"{{ calculator.leftOperand ?? '' }}\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <select class=\"form-control\" name=\"calculator[operator]\">
                                <option value=\"+\" {{ calculator is defined and calculator.operator == '+' ? 'selected' : '' }}>+</option>
                                <option value=\"-\" {{ calculator is defined and calculator.operator == '-' ? 'selected' : '' }}>-</option>
                                <option value=\"*\" {{ calculator is defined and calculator.operator == '*' ? 'selected' : '' }}>*</option>
                                <option value=\"/\" {{ calculator is defined and calculator.operator == '/' ? 'selected' : '' }}>/</option>
                                <option value=\"^\" {{ calculator is defined and calculator.operator == '^' ? 'selected' : '' }}>^</option>
                            </select>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"rightOperand\" placeholder=\"Right Operand\"
                                   name=\"calculator[rightOperand]\" value=\"{{ calculator.rightOperand ?? '' }}\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-2 \">
                            <p>=</p>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"result\" placeholder=\"Result\"
                                   name=\"result\" value=\"{{ result ?? '' }}\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 col-sm-offset-4\">
                            <button type=\"submit\" class=\"btn btn-primary\">Calculate</button>
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
    </div>
{% endblock %}
", "calculator/index.html.twig", "C:\\xampp\\htdocs\\MyProjects\\PHP-Calculator\\app\\Resources\\views\\calculator\\index.html.twig");
    }
}
