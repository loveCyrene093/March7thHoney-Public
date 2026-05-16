using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IAHKPCCPMKM : IMessage<IAHKPCCPMKM>, IMessage, IEquatable<IAHKPCCPMKM>, IDeepCloneable<IAHKPCCPMKM>, IBufferMessage
{
	private static readonly MessageParser<IAHKPCCPMKM> _parser = new MessageParser<IAHKPCCPMKM>(() => new IAHKPCCPMKM());

	private UnknownFieldSet _unknownFields;

	public const int JEOPNONCFNPFieldNumber = 1;

	private uint jEOPNONCFNP_;

	public const int ScoreIdFieldNumber = 2;

	private uint scoreId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IAHKPCCPMKM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IAHKPCCPMKMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public IAHKPCCPMKM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAHKPCCPMKM(IAHKPCCPMKM other)
		: this()
	{
		jEOPNONCFNP_ = other.jEOPNONCFNP_;
		scoreId_ = other.scoreId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAHKPCCPMKM Clone()
	{
		return new IAHKPCCPMKM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IAHKPCCPMKM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IAHKPCCPMKM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JEOPNONCFNP != other.JEOPNONCFNP)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
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
		if (JEOPNONCFNP != 0)
		{
			num ^= JEOPNONCFNP.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
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
		if (JEOPNONCFNP != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JEOPNONCFNP);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ScoreId);
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
		if (JEOPNONCFNP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JEOPNONCFNP);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IAHKPCCPMKM other)
	{
		if (other != null)
		{
			if (other.JEOPNONCFNP != 0)
			{
				JEOPNONCFNP = other.JEOPNONCFNP;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
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
				JEOPNONCFNP = input.ReadUInt32();
				break;
			case 16u:
				ScoreId = input.ReadUInt32();
				break;
			}
		}
	}
}
