using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HLMGOIBAKPH : IMessage<HLMGOIBAKPH>, IMessage, IEquatable<HLMGOIBAKPH>, IDeepCloneable<HLMGOIBAKPH>, IBufferMessage
{
	private static readonly MessageParser<HLMGOIBAKPH> _parser = new MessageParser<HLMGOIBAKPH>(() => new HLMGOIBAKPH());

	private UnknownFieldSet _unknownFields;

	public const int IEPPFKGBFEPFieldNumber = 10;

	private uint iEPPFKGBFEP_;

	public const int GMFCIKBGLJMFieldNumber = 12;

	private static readonly FieldCodec<DFLMKFIFHKB> _repeated_gMFCIKBGLJM_codec = FieldCodec.ForMessage(98u, DFLMKFIFHKB.Parser);

	private readonly RepeatedField<DFLMKFIFHKB> gMFCIKBGLJM_ = new RepeatedField<DFLMKFIFHKB>();

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HLMGOIBAKPH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HLMGOIBAKPHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IEPPFKGBFEP
	{
		get
		{
			return iEPPFKGBFEP_;
		}
		set
		{
			iEPPFKGBFEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DFLMKFIFHKB> GMFCIKBGLJM => gMFCIKBGLJM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLMGOIBAKPH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLMGOIBAKPH(HLMGOIBAKPH other)
		: this()
	{
		iEPPFKGBFEP_ = other.iEPPFKGBFEP_;
		gMFCIKBGLJM_ = other.gMFCIKBGLJM_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLMGOIBAKPH Clone()
	{
		return new HLMGOIBAKPH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HLMGOIBAKPH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HLMGOIBAKPH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IEPPFKGBFEP != other.IEPPFKGBFEP)
		{
			return false;
		}
		if (!gMFCIKBGLJM_.Equals(other.gMFCIKBGLJM_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (IEPPFKGBFEP != 0)
		{
			num ^= IEPPFKGBFEP.GetHashCode();
		}
		num ^= gMFCIKBGLJM_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (IEPPFKGBFEP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IEPPFKGBFEP);
		}
		gMFCIKBGLJM_.WriteTo(ref output, _repeated_gMFCIKBGLJM_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (IEPPFKGBFEP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEPPFKGBFEP);
		}
		num += gMFCIKBGLJM_.CalculateSize(_repeated_gMFCIKBGLJM_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HLMGOIBAKPH other)
	{
		if (other != null)
		{
			if (other.IEPPFKGBFEP != 0)
			{
				IEPPFKGBFEP = other.IEPPFKGBFEP;
			}
			gMFCIKBGLJM_.Add(other.gMFCIKBGLJM_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 80u:
				IEPPFKGBFEP = input.ReadUInt32();
				break;
			case 98u:
				gMFCIKBGLJM_.AddEntriesFrom(ref input, _repeated_gMFCIKBGLJM_codec);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
