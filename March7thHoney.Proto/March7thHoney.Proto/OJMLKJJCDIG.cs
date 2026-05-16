using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OJMLKJJCDIG : IMessage<OJMLKJJCDIG>, IMessage, IEquatable<OJMLKJJCDIG>, IDeepCloneable<OJMLKJJCDIG>, IBufferMessage
{
	private static readonly MessageParser<OJMLKJJCDIG> _parser = new MessageParser<OJMLKJJCDIG>(() => new OJMLKJJCDIG());

	private UnknownFieldSet _unknownFields;

	public const int ScoreIdFieldNumber = 1;

	private uint scoreId_;

	public const int JAEOFFLLDBMFieldNumber = 3;

	private uint jAEOFFLLDBM_;

	public const int JEOPNONCFNPFieldNumber = 8;

	private uint jEOPNONCFNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OJMLKJJCDIG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OJMLKJJCDIGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAEOFFLLDBM
	{
		get
		{
			return jAEOFFLLDBM_;
		}
		set
		{
			jAEOFFLLDBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JEOPNONCFNP
	{
		get
		{
			return jEOPNONCFNP_;
		}
		set
		{
			jEOPNONCFNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJMLKJJCDIG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJMLKJJCDIG(OJMLKJJCDIG other)
		: this()
	{
		scoreId_ = other.scoreId_;
		jAEOFFLLDBM_ = other.jAEOFFLLDBM_;
		jEOPNONCFNP_ = other.jEOPNONCFNP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJMLKJJCDIG Clone()
	{
		return new OJMLKJJCDIG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OJMLKJJCDIG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OJMLKJJCDIG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (JAEOFFLLDBM != other.JAEOFFLLDBM)
		{
			return false;
		}
		if (JEOPNONCFNP != other.JEOPNONCFNP)
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
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (JAEOFFLLDBM != 0)
		{
			num ^= JAEOFFLLDBM.GetHashCode();
		}
		if (JEOPNONCFNP != 0)
		{
			num ^= JEOPNONCFNP.GetHashCode();
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
		if (ScoreId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ScoreId);
		}
		if (JAEOFFLLDBM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JAEOFFLLDBM);
		}
		if (JEOPNONCFNP != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(JEOPNONCFNP);
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
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (JAEOFFLLDBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAEOFFLLDBM);
		}
		if (JEOPNONCFNP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JEOPNONCFNP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OJMLKJJCDIG other)
	{
		if (other != null)
		{
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.JAEOFFLLDBM != 0)
			{
				JAEOFFLLDBM = other.JAEOFFLLDBM;
			}
			if (other.JEOPNONCFNP != 0)
			{
				JEOPNONCFNP = other.JEOPNONCFNP;
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
			case 8u:
				ScoreId = input.ReadUInt32();
				break;
			case 24u:
				JAEOFFLLDBM = input.ReadUInt32();
				break;
			case 64u:
				JEOPNONCFNP = input.ReadUInt32();
				break;
			}
		}
	}
}
