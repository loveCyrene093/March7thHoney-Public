using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KHAHKDLIPKF : IMessage<KHAHKDLIPKF>, IMessage, IEquatable<KHAHKDLIPKF>, IDeepCloneable<KHAHKDLIPKF>, IBufferMessage
{
	private static readonly MessageParser<KHAHKDLIPKF> _parser = new MessageParser<KHAHKDLIPKF>(() => new KHAHKDLIPKF());

	private UnknownFieldSet _unknownFields;

	public const int OKBLCNGFHCLFieldNumber = 2;

	private static readonly FieldCodec<JDKAJMEPECF> _repeated_oKBLCNGFHCL_codec = FieldCodec.ForMessage(18u, JDKAJMEPECF.Parser);

	private readonly RepeatedField<JDKAJMEPECF> oKBLCNGFHCL_ = new RepeatedField<JDKAJMEPECF>();

	public const int JNLDPFHMOJLFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_jNLDPFHMOJL_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> jNLDPFHMOJL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KHAHKDLIPKF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KHAHKDLIPKFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JDKAJMEPECF> OKBLCNGFHCL => oKBLCNGFHCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JNLDPFHMOJL => jNLDPFHMOJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHAHKDLIPKF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHAHKDLIPKF(KHAHKDLIPKF other)
		: this()
	{
		oKBLCNGFHCL_ = other.oKBLCNGFHCL_.Clone();
		jNLDPFHMOJL_ = other.jNLDPFHMOJL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHAHKDLIPKF Clone()
	{
		return new KHAHKDLIPKF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KHAHKDLIPKF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KHAHKDLIPKF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oKBLCNGFHCL_.Equals(other.oKBLCNGFHCL_))
		{
			return false;
		}
		if (!jNLDPFHMOJL_.Equals(other.jNLDPFHMOJL_))
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
		num ^= oKBLCNGFHCL_.GetHashCode();
		num ^= jNLDPFHMOJL_.GetHashCode();
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
		oKBLCNGFHCL_.WriteTo(ref output, _repeated_oKBLCNGFHCL_codec);
		jNLDPFHMOJL_.WriteTo(ref output, _repeated_jNLDPFHMOJL_codec);
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
		num += oKBLCNGFHCL_.CalculateSize(_repeated_oKBLCNGFHCL_codec);
		num += jNLDPFHMOJL_.CalculateSize(_repeated_jNLDPFHMOJL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KHAHKDLIPKF other)
	{
		if (other != null)
		{
			oKBLCNGFHCL_.Add(other.oKBLCNGFHCL_);
			jNLDPFHMOJL_.Add(other.jNLDPFHMOJL_);
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
			case 18u:
				oKBLCNGFHCL_.AddEntriesFrom(ref input, _repeated_oKBLCNGFHCL_codec);
				break;
			case 104u:
			case 106u:
				jNLDPFHMOJL_.AddEntriesFrom(ref input, _repeated_jNLDPFHMOJL_codec);
				break;
			}
		}
	}
}
