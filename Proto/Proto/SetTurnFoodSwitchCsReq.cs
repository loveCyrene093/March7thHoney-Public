using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetTurnFoodSwitchCsReq : IMessage<SetTurnFoodSwitchCsReq>, IMessage, IEquatable<SetTurnFoodSwitchCsReq>, IDeepCloneable<SetTurnFoodSwitchCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetTurnFoodSwitchCsReq> _parser = new MessageParser<SetTurnFoodSwitchCsReq>(() => new SetTurnFoodSwitchCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EDDIOHMNNNBFieldNumber = 3;

	private TurnFoodSwitch eDDIOHMNNNB_;

	public const int AMFLNLGBJGLFieldNumber = 6;

	private bool aMFLNLGBJGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetTurnFoodSwitchCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetTurnFoodSwitchCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TurnFoodSwitch EDDIOHMNNNB
	{
		get
		{
			return eDDIOHMNNNB_;
		}
		set
		{
			eDDIOHMNNNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AMFLNLGBJGL
	{
		get
		{
			return aMFLNLGBJGL_;
		}
		set
		{
			aMFLNLGBJGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetTurnFoodSwitchCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetTurnFoodSwitchCsReq(SetTurnFoodSwitchCsReq other)
		: this()
	{
		eDDIOHMNNNB_ = other.eDDIOHMNNNB_;
		aMFLNLGBJGL_ = other.aMFLNLGBJGL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetTurnFoodSwitchCsReq Clone()
	{
		return new SetTurnFoodSwitchCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetTurnFoodSwitchCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetTurnFoodSwitchCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EDDIOHMNNNB != other.EDDIOHMNNNB)
		{
			return false;
		}
		if (AMFLNLGBJGL != other.AMFLNLGBJGL)
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
		if (EDDIOHMNNNB != TurnFoodSwitch.HindkodobaaPcpdhelpkem)
		{
			num ^= EDDIOHMNNNB.GetHashCode();
		}
		if (AMFLNLGBJGL)
		{
			num ^= AMFLNLGBJGL.GetHashCode();
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
		if (EDDIOHMNNNB != TurnFoodSwitch.HindkodobaaPcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)EDDIOHMNNNB);
		}
		if (AMFLNLGBJGL)
		{
			output.WriteRawTag(48);
			output.WriteBool(AMFLNLGBJGL);
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
		if (EDDIOHMNNNB != TurnFoodSwitch.HindkodobaaPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EDDIOHMNNNB);
		}
		if (AMFLNLGBJGL)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetTurnFoodSwitchCsReq other)
	{
		if (other != null)
		{
			if (other.EDDIOHMNNNB != TurnFoodSwitch.HindkodobaaPcpdhelpkem)
			{
				EDDIOHMNNNB = other.EDDIOHMNNNB;
			}
			if (other.AMFLNLGBJGL)
			{
				AMFLNLGBJGL = other.AMFLNLGBJGL;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				EDDIOHMNNNB = (TurnFoodSwitch)input.ReadEnum();
				break;
			case 48u:
				AMFLNLGBJGL = input.ReadBool();
				break;
			}
		}
	}
}
