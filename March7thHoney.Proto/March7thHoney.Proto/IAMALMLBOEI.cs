using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IAMALMLBOEI : IMessage<IAMALMLBOEI>, IMessage, IEquatable<IAMALMLBOEI>, IDeepCloneable<IAMALMLBOEI>, IBufferMessage
{
	private static readonly MessageParser<IAMALMLBOEI> _parser = new MessageParser<IAMALMLBOEI>(() => new IAMALMLBOEI());

	private UnknownFieldSet _unknownFields;

	public const int JEOPNONCFNPFieldNumber = 1;

	private uint jEOPNONCFNP_;

	public const int NGMANLEFOBJFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_nGMANLEFOBJ_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> nGMANLEFOBJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IAMALMLBOEI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IAMALMLBOEIReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> NGMANLEFOBJ => nGMANLEFOBJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAMALMLBOEI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAMALMLBOEI(IAMALMLBOEI other)
		: this()
	{
		jEOPNONCFNP_ = other.jEOPNONCFNP_;
		nGMANLEFOBJ_ = other.nGMANLEFOBJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAMALMLBOEI Clone()
	{
		return new IAMALMLBOEI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IAMALMLBOEI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IAMALMLBOEI other)
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
		if (!nGMANLEFOBJ_.Equals(other.nGMANLEFOBJ_))
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
		num ^= nGMANLEFOBJ_.GetHashCode();
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
		nGMANLEFOBJ_.WriteTo(ref output, _repeated_nGMANLEFOBJ_codec);
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
		num += nGMANLEFOBJ_.CalculateSize(_repeated_nGMANLEFOBJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IAMALMLBOEI other)
	{
		if (other != null)
		{
			if (other.JEOPNONCFNP != 0)
			{
				JEOPNONCFNP = other.JEOPNONCFNP;
			}
			nGMANLEFOBJ_.Add(other.nGMANLEFOBJ_);
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
			case 18u:
				nGMANLEFOBJ_.AddEntriesFrom(ref input, _repeated_nGMANLEFOBJ_codec);
				break;
			}
		}
	}
}
