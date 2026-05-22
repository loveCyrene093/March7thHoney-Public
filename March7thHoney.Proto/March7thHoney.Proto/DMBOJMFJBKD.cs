using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DMBOJMFJBKD : IMessage<DMBOJMFJBKD>, IMessage, IEquatable<DMBOJMFJBKD>, IDeepCloneable<DMBOJMFJBKD>, IBufferMessage
{
	private static readonly MessageParser<DMBOJMFJBKD> _parser = new MessageParser<DMBOJMFJBKD>(() => new DMBOJMFJBKD());

	private UnknownFieldSet _unknownFields;

	public const int AreaIdFieldNumber = 6;

	private uint areaId_;

	public const int PNHFFKCNNJGFieldNumber = 15;

	private uint pNHFFKCNNJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DMBOJMFJBKD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DMBOJMFJBKDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNHFFKCNNJG
	{
		get
		{
			return pNHFFKCNNJG_;
		}
		set
		{
			pNHFFKCNNJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMBOJMFJBKD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMBOJMFJBKD(DMBOJMFJBKD other)
		: this()
	{
		areaId_ = other.areaId_;
		pNHFFKCNNJG_ = other.pNHFFKCNNJG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMBOJMFJBKD Clone()
	{
		return new DMBOJMFJBKD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DMBOJMFJBKD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DMBOJMFJBKD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (PNHFFKCNNJG != other.PNHFFKCNNJG)
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
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (PNHFFKCNNJG != 0)
		{
			num ^= PNHFFKCNNJG.GetHashCode();
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
		if (AreaId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AreaId);
		}
		if (PNHFFKCNNJG != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(PNHFFKCNNJG);
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
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (PNHFFKCNNJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNHFFKCNNJG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DMBOJMFJBKD other)
	{
		if (other != null)
		{
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			if (other.PNHFFKCNNJG != 0)
			{
				PNHFFKCNNJG = other.PNHFFKCNNJG;
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
				AreaId = input.ReadUInt32();
				break;
			case 120u:
				PNHFFKCNNJG = input.ReadUInt32();
				break;
			}
		}
	}
}
