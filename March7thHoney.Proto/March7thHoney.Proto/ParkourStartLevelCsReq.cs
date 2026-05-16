using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ParkourStartLevelCsReq : IMessage<ParkourStartLevelCsReq>, IMessage, IEquatable<ParkourStartLevelCsReq>, IDeepCloneable<ParkourStartLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<ParkourStartLevelCsReq> _parser = new MessageParser<ParkourStartLevelCsReq>(() => new ParkourStartLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LevelIdFieldNumber = 6;

	private uint levelId_;

	public const int HHPFNDBGIIOFieldNumber = 10;

	private uint hHPFNDBGIIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ParkourStartLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ParkourStartLevelCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HHPFNDBGIIO
	{
		get
		{
			return hHPFNDBGIIO_;
		}
		set
		{
			hHPFNDBGIIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourStartLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourStartLevelCsReq(ParkourStartLevelCsReq other)
		: this()
	{
		levelId_ = other.levelId_;
		hHPFNDBGIIO_ = other.hHPFNDBGIIO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourStartLevelCsReq Clone()
	{
		return new ParkourStartLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ParkourStartLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ParkourStartLevelCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (HHPFNDBGIIO != other.HHPFNDBGIIO)
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
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (HHPFNDBGIIO != 0)
		{
			num ^= HHPFNDBGIIO.GetHashCode();
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
		if (LevelId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LevelId);
		}
		if (HHPFNDBGIIO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(HHPFNDBGIIO);
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
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (HHPFNDBGIIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HHPFNDBGIIO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ParkourStartLevelCsReq other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.HHPFNDBGIIO != 0)
			{
				HHPFNDBGIIO = other.HHPFNDBGIIO;
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
			case 48u:
				LevelId = input.ReadUInt32();
				break;
			case 80u:
				HHPFNDBGIIO = input.ReadUInt32();
				break;
			}
		}
	}
}
