using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingStartStageCsReq : IMessage<ChenLingStartStageCsReq>, IMessage, IEquatable<ChenLingStartStageCsReq>, IDeepCloneable<ChenLingStartStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChenLingStartStageCsReq> _parser = new MessageParser<ChenLingStartStageCsReq>(() => new ChenLingStartStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int StageIdFieldNumber = 2;

	private uint stageId_;

	public const int MHIFFAMMAGIFieldNumber = 15;

	private uint mHIFFAMMAGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingStartStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingStartStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MHIFFAMMAGI
	{
		get
		{
			return mHIFFAMMAGI_;
		}
		set
		{
			mHIFFAMMAGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingStartStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingStartStageCsReq(ChenLingStartStageCsReq other)
		: this()
	{
		stageId_ = other.stageId_;
		mHIFFAMMAGI_ = other.mHIFFAMMAGI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingStartStageCsReq Clone()
	{
		return new ChenLingStartStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingStartStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingStartStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (MHIFFAMMAGI != other.MHIFFAMMAGI)
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
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (MHIFFAMMAGI != 0)
		{
			num ^= MHIFFAMMAGI.GetHashCode();
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
		if (StageId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(StageId);
		}
		if (MHIFFAMMAGI != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MHIFFAMMAGI);
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
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (MHIFFAMMAGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MHIFFAMMAGI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingStartStageCsReq other)
	{
		if (other != null)
		{
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.MHIFFAMMAGI != 0)
			{
				MHIFFAMMAGI = other.MHIFFAMMAGI;
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
			case 16u:
				StageId = input.ReadUInt32();
				break;
			case 120u:
				MHIFFAMMAGI = input.ReadUInt32();
				break;
			}
		}
	}
}
