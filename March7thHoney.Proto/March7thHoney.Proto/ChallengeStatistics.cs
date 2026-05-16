using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeStatistics : IMessage<ChallengeStatistics>, IMessage, IEquatable<ChallengeStatistics>, IDeepCloneable<ChallengeStatistics>, IBufferMessage
{
	private static readonly MessageParser<ChallengeStatistics> _parser = new MessageParser<ChallengeStatistics>(() => new ChallengeStatistics());

	private UnknownFieldSet _unknownFields;

	public const int RecordIdFieldNumber = 10;

	private uint recordId_;

	public const int NCEGEKNLJCEFieldNumber = 14;

	private FPDKBGJKPFF nCEGEKNLJCE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeStatistics> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeStatisticsReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RecordId
	{
		get
		{
			return recordId_;
		}
		set
		{
			recordId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPDKBGJKPFF NCEGEKNLJCE
	{
		get
		{
			return nCEGEKNLJCE_;
		}
		set
		{
			nCEGEKNLJCE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStatistics()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStatistics(ChallengeStatistics other)
		: this()
	{
		recordId_ = other.recordId_;
		nCEGEKNLJCE_ = ((other.nCEGEKNLJCE_ != null) ? other.nCEGEKNLJCE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStatistics Clone()
	{
		return new ChallengeStatistics(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeStatistics);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeStatistics other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RecordId != other.RecordId)
		{
			return false;
		}
		if (!object.Equals(NCEGEKNLJCE, other.NCEGEKNLJCE))
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
		if (RecordId != 0)
		{
			num ^= RecordId.GetHashCode();
		}
		if (nCEGEKNLJCE_ != null)
		{
			num ^= NCEGEKNLJCE.GetHashCode();
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
		if (RecordId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(RecordId);
		}
		if (nCEGEKNLJCE_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(NCEGEKNLJCE);
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
		if (RecordId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RecordId);
		}
		if (nCEGEKNLJCE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NCEGEKNLJCE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeStatistics other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RecordId != 0)
		{
			RecordId = other.RecordId;
		}
		if (other.nCEGEKNLJCE_ != null)
		{
			if (nCEGEKNLJCE_ == null)
			{
				NCEGEKNLJCE = new FPDKBGJKPFF();
			}
			NCEGEKNLJCE.MergeFrom(other.NCEGEKNLJCE);
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
			case 80u:
				RecordId = input.ReadUInt32();
				break;
			case 114u:
				if (nCEGEKNLJCE_ == null)
				{
					NCEGEKNLJCE = new FPDKBGJKPFF();
				}
				input.ReadMessage(NCEGEKNLJCE);
				break;
			}
		}
	}
}
