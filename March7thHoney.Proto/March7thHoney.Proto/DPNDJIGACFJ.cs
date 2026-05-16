using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPNDJIGACFJ : IMessage<DPNDJIGACFJ>, IMessage, IEquatable<DPNDJIGACFJ>, IDeepCloneable<DPNDJIGACFJ>, IBufferMessage
{
	private static readonly MessageParser<DPNDJIGACFJ> _parser = new MessageParser<DPNDJIGACFJ>(() => new DPNDJIGACFJ());

	private UnknownFieldSet _unknownFields;

	public const int PHCAALBPKGKFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_pHCAALBPKGK_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> pHCAALBPKGK_ = new RepeatedField<uint>();

	public const int CMGCNFLGHLMFieldNumber = 11;

	private KAIELJPMGHL cMGCNFLGHLM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPNDJIGACFJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPNDJIGACFJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PHCAALBPKGK => pHCAALBPKGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAIELJPMGHL CMGCNFLGHLM
	{
		get
		{
			return cMGCNFLGHLM_;
		}
		set
		{
			cMGCNFLGHLM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPNDJIGACFJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPNDJIGACFJ(DPNDJIGACFJ other)
		: this()
	{
		pHCAALBPKGK_ = other.pHCAALBPKGK_.Clone();
		cMGCNFLGHLM_ = ((other.cMGCNFLGHLM_ != null) ? other.cMGCNFLGHLM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPNDJIGACFJ Clone()
	{
		return new DPNDJIGACFJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPNDJIGACFJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPNDJIGACFJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pHCAALBPKGK_.Equals(other.pHCAALBPKGK_))
		{
			return false;
		}
		if (!object.Equals(CMGCNFLGHLM, other.CMGCNFLGHLM))
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
		num ^= pHCAALBPKGK_.GetHashCode();
		if (cMGCNFLGHLM_ != null)
		{
			num ^= CMGCNFLGHLM.GetHashCode();
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
		pHCAALBPKGK_.WriteTo(ref output, _repeated_pHCAALBPKGK_codec);
		if (cMGCNFLGHLM_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CMGCNFLGHLM);
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
		num += pHCAALBPKGK_.CalculateSize(_repeated_pHCAALBPKGK_codec);
		if (cMGCNFLGHLM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CMGCNFLGHLM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPNDJIGACFJ other)
	{
		if (other == null)
		{
			return;
		}
		pHCAALBPKGK_.Add(other.pHCAALBPKGK_);
		if (other.cMGCNFLGHLM_ != null)
		{
			if (cMGCNFLGHLM_ == null)
			{
				CMGCNFLGHLM = new KAIELJPMGHL();
			}
			CMGCNFLGHLM.MergeFrom(other.CMGCNFLGHLM);
		}
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
			case 48u:
			case 50u:
				pHCAALBPKGK_.AddEntriesFrom(ref input, _repeated_pHCAALBPKGK_codec);
				break;
			case 90u:
				if (cMGCNFLGHLM_ == null)
				{
					CMGCNFLGHLM = new KAIELJPMGHL();
				}
				input.ReadMessage(CMGCNFLGHLM);
				break;
			}
		}
	}
}
