using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFKOMCNLMDG : IMessage<GFKOMCNLMDG>, IMessage, IEquatable<GFKOMCNLMDG>, IDeepCloneable<GFKOMCNLMDG>, IBufferMessage
{
	private static readonly MessageParser<GFKOMCNLMDG> _parser = new MessageParser<GFKOMCNLMDG>(() => new GFKOMCNLMDG());

	private UnknownFieldSet _unknownFields;

	public const int GNKEDOEHNAIFieldNumber = 8;

	private static readonly MapField<uint, uint>.Codec _map_gNKEDOEHNAI_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 66u);

	private readonly MapField<uint, uint> gNKEDOEHNAI_ = new MapField<uint, uint>();

	public const int CurNumFieldNumber = 11;

	private uint curNum_;

	public const int MaxNumFieldNumber = 15;

	private uint maxNum_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFKOMCNLMDG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFKOMCNLMDGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> GNKEDOEHNAI => gNKEDOEHNAI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurNum
	{
		get
		{
			return curNum_;
		}
		set
		{
			curNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxNum
	{
		get
		{
			return maxNum_;
		}
		set
		{
			maxNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFKOMCNLMDG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFKOMCNLMDG(GFKOMCNLMDG other)
		: this()
	{
		gNKEDOEHNAI_ = other.gNKEDOEHNAI_.Clone();
		curNum_ = other.curNum_;
		maxNum_ = other.maxNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFKOMCNLMDG Clone()
	{
		return new GFKOMCNLMDG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFKOMCNLMDG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFKOMCNLMDG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!GNKEDOEHNAI.Equals(other.GNKEDOEHNAI))
		{
			return false;
		}
		if (CurNum != other.CurNum)
		{
			return false;
		}
		if (MaxNum != other.MaxNum)
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
		num ^= GNKEDOEHNAI.GetHashCode();
		if (CurNum != 0)
		{
			num ^= CurNum.GetHashCode();
		}
		if (MaxNum != 0)
		{
			num ^= MaxNum.GetHashCode();
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
		gNKEDOEHNAI_.WriteTo(ref output, _map_gNKEDOEHNAI_codec);
		if (CurNum != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CurNum);
		}
		if (MaxNum != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MaxNum);
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
		num += gNKEDOEHNAI_.CalculateSize(_map_gNKEDOEHNAI_codec);
		if (CurNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurNum);
		}
		if (MaxNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFKOMCNLMDG other)
	{
		if (other != null)
		{
			gNKEDOEHNAI_.MergeFrom(other.gNKEDOEHNAI_);
			if (other.CurNum != 0)
			{
				CurNum = other.CurNum;
			}
			if (other.MaxNum != 0)
			{
				MaxNum = other.MaxNum;
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
			case 66u:
				gNKEDOEHNAI_.AddEntriesFrom(ref input, _map_gNKEDOEHNAI_codec);
				break;
			case 88u:
				CurNum = input.ReadUInt32();
				break;
			case 120u:
				MaxNum = input.ReadUInt32();
				break;
			}
		}
	}
}
