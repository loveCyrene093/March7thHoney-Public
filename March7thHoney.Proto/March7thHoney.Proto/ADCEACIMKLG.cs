using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ADCEACIMKLG : IMessage<ADCEACIMKLG>, IMessage, IEquatable<ADCEACIMKLG>, IDeepCloneable<ADCEACIMKLG>, IBufferMessage
{
	private static readonly MessageParser<ADCEACIMKLG> _parser = new MessageParser<ADCEACIMKLG>(() => new ADCEACIMKLG());

	private UnknownFieldSet _unknownFields;

	public const int EDDIOHMNNNBFieldNumber = 4;

	private TurnFoodSwitch eDDIOHMNNNB_;

	public const int AMFLNLGBJGLFieldNumber = 7;

	private bool aMFLNLGBJGL_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ADCEACIMKLG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ADCEACIMKLGReflection.Descriptor.MessageTypes[0];

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADCEACIMKLG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADCEACIMKLG(ADCEACIMKLG other)
		: this()
	{
		eDDIOHMNNNB_ = other.eDDIOHMNNNB_;
		aMFLNLGBJGL_ = other.aMFLNLGBJGL_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADCEACIMKLG Clone()
	{
		return new ADCEACIMKLG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ADCEACIMKLG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ADCEACIMKLG other)
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
		if (Retcode != other.Retcode)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
			output.WriteRawTag(32);
			output.WriteEnum((int)EDDIOHMNNNB);
		}
		if (AMFLNLGBJGL)
		{
			output.WriteRawTag(56);
			output.WriteBool(AMFLNLGBJGL);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ADCEACIMKLG other)
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
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 32u:
				EDDIOHMNNNB = (TurnFoodSwitch)input.ReadEnum();
				break;
			case 56u:
				AMFLNLGBJGL = input.ReadBool();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
