using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PMKEENOFAPC : IMessage<PMKEENOFAPC>, IMessage, IEquatable<PMKEENOFAPC>, IDeepCloneable<PMKEENOFAPC>, IBufferMessage
{
	private static readonly MessageParser<PMKEENOFAPC> _parser = new MessageParser<PMKEENOFAPC>(() => new PMKEENOFAPC());

	private UnknownFieldSet _unknownFields;

	public const int HNLAEIBDFJMFieldNumber = 2;

	private OLJJJBCKLDK hNLAEIBDFJM_;

	public const int DNAOBFLACIGFieldNumber = 7;

	private static readonly FieldCodec<OLJJJBCKLDK> _repeated_dNAOBFLACIG_codec = FieldCodec.ForMessage(58u, OLJJJBCKLDK.Parser);

	private readonly RepeatedField<OLJJJBCKLDK> dNAOBFLACIG_ = new RepeatedField<OLJJJBCKLDK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PMKEENOFAPC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PMKEENOFAPCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLJJJBCKLDK HNLAEIBDFJM
	{
		get
		{
			return hNLAEIBDFJM_;
		}
		set
		{
			hNLAEIBDFJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OLJJJBCKLDK> DNAOBFLACIG => dNAOBFLACIG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMKEENOFAPC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMKEENOFAPC(PMKEENOFAPC other)
		: this()
	{
		hNLAEIBDFJM_ = ((other.hNLAEIBDFJM_ != null) ? other.hNLAEIBDFJM_.Clone() : null);
		dNAOBFLACIG_ = other.dNAOBFLACIG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMKEENOFAPC Clone()
	{
		return new PMKEENOFAPC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PMKEENOFAPC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PMKEENOFAPC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HNLAEIBDFJM, other.HNLAEIBDFJM))
		{
			return false;
		}
		if (!dNAOBFLACIG_.Equals(other.dNAOBFLACIG_))
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
		if (hNLAEIBDFJM_ != null)
		{
			num ^= HNLAEIBDFJM.GetHashCode();
		}
		num ^= dNAOBFLACIG_.GetHashCode();
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
		if (hNLAEIBDFJM_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HNLAEIBDFJM);
		}
		dNAOBFLACIG_.WriteTo(ref output, _repeated_dNAOBFLACIG_codec);
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
		if (hNLAEIBDFJM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HNLAEIBDFJM);
		}
		num += dNAOBFLACIG_.CalculateSize(_repeated_dNAOBFLACIG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PMKEENOFAPC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hNLAEIBDFJM_ != null)
		{
			if (hNLAEIBDFJM_ == null)
			{
				HNLAEIBDFJM = new OLJJJBCKLDK();
			}
			HNLAEIBDFJM.MergeFrom(other.HNLAEIBDFJM);
		}
		dNAOBFLACIG_.Add(other.dNAOBFLACIG_);
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
			case 18u:
				if (hNLAEIBDFJM_ == null)
				{
					HNLAEIBDFJM = new OLJJJBCKLDK();
				}
				input.ReadMessage(HNLAEIBDFJM);
				break;
			case 58u:
				dNAOBFLACIG_.AddEntriesFrom(ref input, _repeated_dNAOBFLACIG_codec);
				break;
			}
		}
	}
}
