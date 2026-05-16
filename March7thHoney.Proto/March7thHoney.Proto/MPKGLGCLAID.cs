using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MPKGLGCLAID : IMessage<MPKGLGCLAID>, IMessage, IEquatable<MPKGLGCLAID>, IDeepCloneable<MPKGLGCLAID>, IBufferMessage
{
	private static readonly MessageParser<MPKGLGCLAID> _parser = new MessageParser<MPKGLGCLAID>(() => new MPKGLGCLAID());

	private UnknownFieldSet _unknownFields;

	public const int PAMGHMDJAJAFieldNumber = 5;

	private JLPGIGPCIAG pAMGHMDJAJA_;

	public const int LKJOEODAOMMFieldNumber = 10;

	private static readonly FieldCodec<FCLNBHMAIGC> _repeated_lKJOEODAOMM_codec = FieldCodec.ForMessage(82u, FCLNBHMAIGC.Parser);

	private readonly RepeatedField<FCLNBHMAIGC> lKJOEODAOMM_ = new RepeatedField<FCLNBHMAIGC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MPKGLGCLAID> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MPKGLGCLAIDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLPGIGPCIAG PAMGHMDJAJA
	{
		get
		{
			return pAMGHMDJAJA_;
		}
		set
		{
			pAMGHMDJAJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FCLNBHMAIGC> LKJOEODAOMM => lKJOEODAOMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPKGLGCLAID()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPKGLGCLAID(MPKGLGCLAID other)
		: this()
	{
		pAMGHMDJAJA_ = ((other.pAMGHMDJAJA_ != null) ? other.pAMGHMDJAJA_.Clone() : null);
		lKJOEODAOMM_ = other.lKJOEODAOMM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPKGLGCLAID Clone()
	{
		return new MPKGLGCLAID(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MPKGLGCLAID);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MPKGLGCLAID other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PAMGHMDJAJA, other.PAMGHMDJAJA))
		{
			return false;
		}
		if (!lKJOEODAOMM_.Equals(other.lKJOEODAOMM_))
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
		if (pAMGHMDJAJA_ != null)
		{
			num ^= PAMGHMDJAJA.GetHashCode();
		}
		num ^= lKJOEODAOMM_.GetHashCode();
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
		if (pAMGHMDJAJA_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PAMGHMDJAJA);
		}
		lKJOEODAOMM_.WriteTo(ref output, _repeated_lKJOEODAOMM_codec);
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
		if (pAMGHMDJAJA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PAMGHMDJAJA);
		}
		num += lKJOEODAOMM_.CalculateSize(_repeated_lKJOEODAOMM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MPKGLGCLAID other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pAMGHMDJAJA_ != null)
		{
			if (pAMGHMDJAJA_ == null)
			{
				PAMGHMDJAJA = new JLPGIGPCIAG();
			}
			PAMGHMDJAJA.MergeFrom(other.PAMGHMDJAJA);
		}
		lKJOEODAOMM_.Add(other.lKJOEODAOMM_);
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
				if (pAMGHMDJAJA_ == null)
				{
					PAMGHMDJAJA = new JLPGIGPCIAG();
				}
				input.ReadMessage(PAMGHMDJAJA);
				break;
			case 82u:
				lKJOEODAOMM_.AddEntriesFrom(ref input, _repeated_lKJOEODAOMM_codec);
				break;
			}
		}
	}
}
