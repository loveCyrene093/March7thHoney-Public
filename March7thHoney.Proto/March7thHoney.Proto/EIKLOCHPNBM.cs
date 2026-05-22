using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EIKLOCHPNBM : IMessage<EIKLOCHPNBM>, IMessage, IEquatable<EIKLOCHPNBM>, IDeepCloneable<EIKLOCHPNBM>, IBufferMessage
{
	private static readonly MessageParser<EIKLOCHPNBM> _parser = new MessageParser<EIKLOCHPNBM>(() => new EIKLOCHPNBM());

	private UnknownFieldSet _unknownFields;

	public const int EFBAMGJDAEHFieldNumber = 5;

	private JNBGIDELOGF eFBAMGJDAEH_;

	public const int NLHDFBNLJHJFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_nLHDFBNLJHJ_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> nLHDFBNLJHJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EIKLOCHPNBM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EIKLOCHPNBMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNBGIDELOGF EFBAMGJDAEH
	{
		get
		{
			return eFBAMGJDAEH_;
		}
		set
		{
			eFBAMGJDAEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NLHDFBNLJHJ => nLHDFBNLJHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIKLOCHPNBM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIKLOCHPNBM(EIKLOCHPNBM other)
		: this()
	{
		eFBAMGJDAEH_ = ((other.eFBAMGJDAEH_ != null) ? other.eFBAMGJDAEH_.Clone() : null);
		nLHDFBNLJHJ_ = other.nLHDFBNLJHJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIKLOCHPNBM Clone()
	{
		return new EIKLOCHPNBM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EIKLOCHPNBM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EIKLOCHPNBM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EFBAMGJDAEH, other.EFBAMGJDAEH))
		{
			return false;
		}
		if (!nLHDFBNLJHJ_.Equals(other.nLHDFBNLJHJ_))
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
		if (eFBAMGJDAEH_ != null)
		{
			num ^= EFBAMGJDAEH.GetHashCode();
		}
		num ^= nLHDFBNLJHJ_.GetHashCode();
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
		if (eFBAMGJDAEH_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(EFBAMGJDAEH);
		}
		nLHDFBNLJHJ_.WriteTo(ref output, _repeated_nLHDFBNLJHJ_codec);
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
		if (eFBAMGJDAEH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFBAMGJDAEH);
		}
		num += nLHDFBNLJHJ_.CalculateSize(_repeated_nLHDFBNLJHJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EIKLOCHPNBM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eFBAMGJDAEH_ != null)
		{
			if (eFBAMGJDAEH_ == null)
			{
				EFBAMGJDAEH = new JNBGIDELOGF();
			}
			EFBAMGJDAEH.MergeFrom(other.EFBAMGJDAEH);
		}
		nLHDFBNLJHJ_.Add(other.nLHDFBNLJHJ_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 42u:
				if (eFBAMGJDAEH_ == null)
				{
					EFBAMGJDAEH = new JNBGIDELOGF();
				}
				input.ReadMessage(EFBAMGJDAEH);
				break;
			case 120u:
			case 122u:
				nLHDFBNLJHJ_.AddEntriesFrom(ref input, _repeated_nLHDFBNLJHJ_codec);
				break;
			}
		}
	}
}
