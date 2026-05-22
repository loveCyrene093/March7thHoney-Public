using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FeatureSwitchClosedScNotify : IMessage<FeatureSwitchClosedScNotify>, IMessage, IEquatable<FeatureSwitchClosedScNotify>, IDeepCloneable<FeatureSwitchClosedScNotify>, IBufferMessage
{
	private static readonly MessageParser<FeatureSwitchClosedScNotify> _parser = new MessageParser<FeatureSwitchClosedScNotify>(() => new FeatureSwitchClosedScNotify());

	private UnknownFieldSet _unknownFields;

	public const int OFDFKMLOGKOFieldNumber = 4;

	private FeatureSwitchType oFDFKMLOGKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FeatureSwitchClosedScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FeatureSwitchClosedScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSwitchType OFDFKMLOGKO
	{
		get
		{
			return oFDFKMLOGKO_;
		}
		set
		{
			oFDFKMLOGKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSwitchClosedScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSwitchClosedScNotify(FeatureSwitchClosedScNotify other)
		: this()
	{
		oFDFKMLOGKO_ = other.oFDFKMLOGKO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSwitchClosedScNotify Clone()
	{
		return new FeatureSwitchClosedScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FeatureSwitchClosedScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FeatureSwitchClosedScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OFDFKMLOGKO != other.OFDFKMLOGKO)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (OFDFKMLOGKO != FeatureSwitchType.IgckijddjfjAhmckdaolne)
		{
			num ^= OFDFKMLOGKO.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (OFDFKMLOGKO != FeatureSwitchType.IgckijddjfjAhmckdaolne)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)OFDFKMLOGKO);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (OFDFKMLOGKO != FeatureSwitchType.IgckijddjfjAhmckdaolne)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OFDFKMLOGKO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FeatureSwitchClosedScNotify other)
	{
		if (other != null)
		{
			if (other.OFDFKMLOGKO != FeatureSwitchType.IgckijddjfjAhmckdaolne)
			{
				OFDFKMLOGKO = other.OFDFKMLOGKO;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				OFDFKMLOGKO = (FeatureSwitchType)input.ReadEnum();
			}
		}
	}
}
