using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeChallengeRaidRewardCsReq : IMessage<TakeChallengeRaidRewardCsReq>, IMessage, IEquatable<TakeChallengeRaidRewardCsReq>, IDeepCloneable<TakeChallengeRaidRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeChallengeRaidRewardCsReq> _parser = new MessageParser<TakeChallengeRaidRewardCsReq>(() => new TakeChallengeRaidRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KIBNLNFPFICFieldNumber = 11;

	private uint kIBNLNFPFIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeChallengeRaidRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeChallengeRaidRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KIBNLNFPFIC
	{
		get
		{
			return kIBNLNFPFIC_;
		}
		set
		{
			kIBNLNFPFIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeChallengeRaidRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeChallengeRaidRewardCsReq(TakeChallengeRaidRewardCsReq other)
		: this()
	{
		kIBNLNFPFIC_ = other.kIBNLNFPFIC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeChallengeRaidRewardCsReq Clone()
	{
		return new TakeChallengeRaidRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeChallengeRaidRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeChallengeRaidRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KIBNLNFPFIC != other.KIBNLNFPFIC)
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
		if (KIBNLNFPFIC != 0)
		{
			num ^= KIBNLNFPFIC.GetHashCode();
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
		if (KIBNLNFPFIC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KIBNLNFPFIC);
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
		if (KIBNLNFPFIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KIBNLNFPFIC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeChallengeRaidRewardCsReq other)
	{
		if (other != null)
		{
			if (other.KIBNLNFPFIC != 0)
			{
				KIBNLNFPFIC = other.KIBNLNFPFIC;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KIBNLNFPFIC = input.ReadUInt32();
			}
		}
	}
}
