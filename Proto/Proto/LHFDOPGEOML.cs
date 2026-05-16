using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHFDOPGEOML : IMessage<LHFDOPGEOML>, IMessage, IEquatable<LHFDOPGEOML>, IDeepCloneable<LHFDOPGEOML>, IBufferMessage
{
	private static readonly MessageParser<LHFDOPGEOML> _parser = new MessageParser<LHFDOPGEOML>(() => new LHFDOPGEOML());

	private UnknownFieldSet _unknownFields;

	public const int ANLGPLOLMOHFieldNumber = 3;

	private uint aNLGPLOLMOH_;

	public const int OGHGLMGJGEMFieldNumber = 4;

	private static readonly MapField<string, uint>.Codec _map_oGHGLMGJGEM_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 34u);

	private readonly MapField<string, uint> oGHGLMGJGEM_ = new MapField<string, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHFDOPGEOML> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHFDOPGEOMLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ANLGPLOLMOH
	{
		get
		{
			return aNLGPLOLMOH_;
		}
		set
		{
			aNLGPLOLMOH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, uint> OGHGLMGJGEM => oGHGLMGJGEM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHFDOPGEOML()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHFDOPGEOML(LHFDOPGEOML other)
		: this()
	{
		aNLGPLOLMOH_ = other.aNLGPLOLMOH_;
		oGHGLMGJGEM_ = other.oGHGLMGJGEM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHFDOPGEOML Clone()
	{
		return new LHFDOPGEOML(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHFDOPGEOML);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHFDOPGEOML other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ANLGPLOLMOH != other.ANLGPLOLMOH)
		{
			return false;
		}
		if (!OGHGLMGJGEM.Equals(other.OGHGLMGJGEM))
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
		if (ANLGPLOLMOH != 0)
		{
			num ^= ANLGPLOLMOH.GetHashCode();
		}
		num ^= OGHGLMGJGEM.GetHashCode();
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
		if (ANLGPLOLMOH != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ANLGPLOLMOH);
		}
		oGHGLMGJGEM_.WriteTo(ref output, _map_oGHGLMGJGEM_codec);
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
		if (ANLGPLOLMOH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ANLGPLOLMOH);
		}
		num += oGHGLMGJGEM_.CalculateSize(_map_oGHGLMGJGEM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHFDOPGEOML other)
	{
		if (other != null)
		{
			if (other.ANLGPLOLMOH != 0)
			{
				ANLGPLOLMOH = other.ANLGPLOLMOH;
			}
			oGHGLMGJGEM_.MergeFrom(other.oGHGLMGJGEM_);
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
			case 24u:
				ANLGPLOLMOH = input.ReadUInt32();
				break;
			case 34u:
				oGHGLMGJGEM_.AddEntriesFrom(ref input, _map_oGHGLMGJGEM_codec);
				break;
			}
		}
	}
}
