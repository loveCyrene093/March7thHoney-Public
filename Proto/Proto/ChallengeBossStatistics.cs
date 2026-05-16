using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBossStatistics : IMessage<ChallengeBossStatistics>, IMessage, IEquatable<ChallengeBossStatistics>, IDeepCloneable<ChallengeBossStatistics>, IBufferMessage
{
	private static readonly MessageParser<ChallengeBossStatistics> _parser = new MessageParser<ChallengeBossStatistics>(() => new ChallengeBossStatistics());

	private UnknownFieldSet _unknownFields;

	public const int NCEGEKNLJCEFieldNumber = 9;

	private BHFAFMDHKKC nCEGEKNLJCE_;

	public const int RecordIdFieldNumber = 12;

	private uint recordId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBossStatistics> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeBossStatisticsReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHFAFMDHKKC NCEGEKNLJCE
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
	public ChallengeBossStatistics()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossStatistics(ChallengeBossStatistics other)
		: this()
	{
		nCEGEKNLJCE_ = ((other.nCEGEKNLJCE_ != null) ? other.nCEGEKNLJCE_.Clone() : null);
		recordId_ = other.recordId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossStatistics Clone()
	{
		return new ChallengeBossStatistics(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeBossStatistics);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBossStatistics other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NCEGEKNLJCE, other.NCEGEKNLJCE))
		{
			return false;
		}
		if (RecordId != other.RecordId)
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
		if (nCEGEKNLJCE_ != null)
		{
			num ^= NCEGEKNLJCE.GetHashCode();
		}
		if (RecordId != 0)
		{
			num ^= RecordId.GetHashCode();
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
		if (nCEGEKNLJCE_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(NCEGEKNLJCE);
		}
		if (RecordId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(RecordId);
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
		if (nCEGEKNLJCE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NCEGEKNLJCE);
		}
		if (RecordId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RecordId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBossStatistics other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nCEGEKNLJCE_ != null)
		{
			if (nCEGEKNLJCE_ == null)
			{
				NCEGEKNLJCE = new BHFAFMDHKKC();
			}
			NCEGEKNLJCE.MergeFrom(other.NCEGEKNLJCE);
		}
		if (other.RecordId != 0)
		{
			RecordId = other.RecordId;
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
			case 74u:
				if (nCEGEKNLJCE_ == null)
				{
					NCEGEKNLJCE = new BHFAFMDHKKC();
				}
				input.ReadMessage(NCEGEKNLJCE);
				break;
			case 96u:
				RecordId = input.ReadUInt32();
				break;
			}
		}
	}
}
