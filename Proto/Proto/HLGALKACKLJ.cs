using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HLGALKACKLJ : IMessage<HLGALKACKLJ>, IMessage, IEquatable<HLGALKACKLJ>, IDeepCloneable<HLGALKACKLJ>, IBufferMessage
{
	private static readonly MessageParser<HLGALKACKLJ> _parser = new MessageParser<HLGALKACKLJ>(() => new HLGALKACKLJ());

	private UnknownFieldSet _unknownFields;

	public const int EHOMKGGOEJDFieldNumber = 2;

	private uint eHOMKGGOEJD_;

	public const int TalentInfoFieldNumber = 11;

	private MCACDFHCPIE talentInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HLGALKACKLJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HLGALKACKLJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EHOMKGGOEJD
	{
		get
		{
			return eHOMKGGOEJD_;
		}
		set
		{
			eHOMKGGOEJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCACDFHCPIE TalentInfo
	{
		get
		{
			return talentInfo_;
		}
		set
		{
			talentInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLGALKACKLJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLGALKACKLJ(HLGALKACKLJ other)
		: this()
	{
		eHOMKGGOEJD_ = other.eHOMKGGOEJD_;
		talentInfo_ = ((other.talentInfo_ != null) ? other.talentInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLGALKACKLJ Clone()
	{
		return new HLGALKACKLJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HLGALKACKLJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HLGALKACKLJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EHOMKGGOEJD != other.EHOMKGGOEJD)
		{
			return false;
		}
		if (!object.Equals(TalentInfo, other.TalentInfo))
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
		if (EHOMKGGOEJD != 0)
		{
			num ^= EHOMKGGOEJD.GetHashCode();
		}
		if (talentInfo_ != null)
		{
			num ^= TalentInfo.GetHashCode();
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
		if (EHOMKGGOEJD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EHOMKGGOEJD);
		}
		if (talentInfo_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(TalentInfo);
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
		if (EHOMKGGOEJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EHOMKGGOEJD);
		}
		if (talentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HLGALKACKLJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EHOMKGGOEJD != 0)
		{
			EHOMKGGOEJD = other.EHOMKGGOEJD;
		}
		if (other.talentInfo_ != null)
		{
			if (talentInfo_ == null)
			{
				TalentInfo = new MCACDFHCPIE();
			}
			TalentInfo.MergeFrom(other.TalentInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 16u:
				EHOMKGGOEJD = input.ReadUInt32();
				break;
			case 90u:
				if (talentInfo_ == null)
				{
					TalentInfo = new MCACDFHCPIE();
				}
				input.ReadMessage(TalentInfo);
				break;
			}
		}
	}
}
