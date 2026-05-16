using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHIPKINNCAP : IMessage<HHIPKINNCAP>, IMessage, IEquatable<HHIPKINNCAP>, IDeepCloneable<HHIPKINNCAP>, IBufferMessage
{
	private static readonly MessageParser<HHIPKINNCAP> _parser = new MessageParser<HHIPKINNCAP>(() => new HHIPKINNCAP());

	private UnknownFieldSet _unknownFields;

	public const int IBNELAJJOAOFieldNumber = 1;

	private uint iBNELAJJOAO_;

	public const int NGAGHMDLPGFFieldNumber = 2;

	private uint nGAGHMDLPGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHIPKINNCAP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHIPKINNCAPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IBNELAJJOAO
	{
		get
		{
			return iBNELAJJOAO_;
		}
		set
		{
			iBNELAJJOAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGAGHMDLPGF
	{
		get
		{
			return nGAGHMDLPGF_;
		}
		set
		{
			nGAGHMDLPGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHIPKINNCAP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHIPKINNCAP(HHIPKINNCAP other)
		: this()
	{
		iBNELAJJOAO_ = other.iBNELAJJOAO_;
		nGAGHMDLPGF_ = other.nGAGHMDLPGF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHIPKINNCAP Clone()
	{
		return new HHIPKINNCAP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHIPKINNCAP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHIPKINNCAP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IBNELAJJOAO != other.IBNELAJJOAO)
		{
			return false;
		}
		if (NGAGHMDLPGF != other.NGAGHMDLPGF)
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
		if (IBNELAJJOAO != 0)
		{
			num ^= IBNELAJJOAO.GetHashCode();
		}
		if (NGAGHMDLPGF != 0)
		{
			num ^= NGAGHMDLPGF.GetHashCode();
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
		if (IBNELAJJOAO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IBNELAJJOAO);
		}
		if (NGAGHMDLPGF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NGAGHMDLPGF);
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
		if (IBNELAJJOAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IBNELAJJOAO);
		}
		if (NGAGHMDLPGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGAGHMDLPGF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHIPKINNCAP other)
	{
		if (other != null)
		{
			if (other.IBNELAJJOAO != 0)
			{
				IBNELAJJOAO = other.IBNELAJJOAO;
			}
			if (other.NGAGHMDLPGF != 0)
			{
				NGAGHMDLPGF = other.NGAGHMDLPGF;
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
				IBNELAJJOAO = input.ReadUInt32();
				break;
			case 16u:
				NGAGHMDLPGF = input.ReadUInt32();
				break;
			}
		}
	}
}
