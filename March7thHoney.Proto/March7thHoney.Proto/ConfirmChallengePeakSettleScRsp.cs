using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ConfirmChallengePeakSettleScRsp : IMessage<ConfirmChallengePeakSettleScRsp>, IMessage, IEquatable<ConfirmChallengePeakSettleScRsp>, IDeepCloneable<ConfirmChallengePeakSettleScRsp>, IBufferMessage
{
	private static readonly MessageParser<ConfirmChallengePeakSettleScRsp> _parser = new MessageParser<ConfirmChallengePeakSettleScRsp>(() => new ConfirmChallengePeakSettleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PeakIdFieldNumber = 7;

	private uint peakId_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int ABHOLNJNPJMFieldNumber = 12;

	private bool aBHOLNJNPJM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ConfirmChallengePeakSettleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ConfirmChallengePeakSettleScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PeakId
	{
		get
		{
			return peakId_;
		}
		set
		{
			peakId_ = value;
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
	public bool ABHOLNJNPJM
	{
		get
		{
			return aBHOLNJNPJM_;
		}
		set
		{
			aBHOLNJNPJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConfirmChallengePeakSettleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConfirmChallengePeakSettleScRsp(ConfirmChallengePeakSettleScRsp other)
		: this()
	{
		peakId_ = other.peakId_;
		retcode_ = other.retcode_;
		aBHOLNJNPJM_ = other.aBHOLNJNPJM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConfirmChallengePeakSettleScRsp Clone()
	{
		return new ConfirmChallengePeakSettleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ConfirmChallengePeakSettleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ConfirmChallengePeakSettleScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PeakId != other.PeakId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ABHOLNJNPJM != other.ABHOLNJNPJM)
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
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ABHOLNJNPJM)
		{
			num ^= ABHOLNJNPJM.GetHashCode();
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
		if (PeakId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PeakId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (ABHOLNJNPJM)
		{
			output.WriteRawTag(96);
			output.WriteBool(ABHOLNJNPJM);
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
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ABHOLNJNPJM)
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
	public void MergeFrom(ConfirmChallengePeakSettleScRsp other)
	{
		if (other != null)
		{
			if (other.PeakId != 0)
			{
				PeakId = other.PeakId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.ABHOLNJNPJM)
			{
				ABHOLNJNPJM = other.ABHOLNJNPJM;
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
			case 56u:
				PeakId = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				ABHOLNJNPJM = input.ReadBool();
				break;
			}
		}
	}
}
