using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IIKMHADLJFL : IMessage<IIKMHADLJFL>, IMessage, IEquatable<IIKMHADLJFL>, IDeepCloneable<IIKMHADLJFL>, IBufferMessage
{
	private static readonly MessageParser<IIKMHADLJFL> _parser = new MessageParser<IIKMHADLJFL>(() => new IIKMHADLJFL());

	private UnknownFieldSet _unknownFields;

	public const int CLAFNDLGDAOFieldNumber = 3;

	private EFEGKDHEMFN cLAFNDLGDAO_;

	public const int HMFCCFCKEFOFieldNumber = 8;

	private EFEGKDHEMFN hMFCCFCKEFO_;

	public const int ECAJLPAJEKFFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_eCAJLPAJEKF_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> eCAJLPAJEKF_ = new RepeatedField<uint>();

	public const int ItemStackCountFieldNumber = 14;

	private EFEGKDHEMFN itemStackCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IIKMHADLJFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IIKMHADLJFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN CLAFNDLGDAO
	{
		get
		{
			return cLAFNDLGDAO_;
		}
		set
		{
			cLAFNDLGDAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN HMFCCFCKEFO
	{
		get
		{
			return hMFCCFCKEFO_;
		}
		set
		{
			hMFCCFCKEFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ECAJLPAJEKF => eCAJLPAJEKF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN ItemStackCount
	{
		get
		{
			return itemStackCount_;
		}
		set
		{
			itemStackCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIKMHADLJFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIKMHADLJFL(IIKMHADLJFL other)
		: this()
	{
		cLAFNDLGDAO_ = ((other.cLAFNDLGDAO_ != null) ? other.cLAFNDLGDAO_.Clone() : null);
		hMFCCFCKEFO_ = ((other.hMFCCFCKEFO_ != null) ? other.hMFCCFCKEFO_.Clone() : null);
		eCAJLPAJEKF_ = other.eCAJLPAJEKF_.Clone();
		itemStackCount_ = ((other.itemStackCount_ != null) ? other.itemStackCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIKMHADLJFL Clone()
	{
		return new IIKMHADLJFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IIKMHADLJFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IIKMHADLJFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CLAFNDLGDAO, other.CLAFNDLGDAO))
		{
			return false;
		}
		if (!object.Equals(HMFCCFCKEFO, other.HMFCCFCKEFO))
		{
			return false;
		}
		if (!eCAJLPAJEKF_.Equals(other.eCAJLPAJEKF_))
		{
			return false;
		}
		if (!object.Equals(ItemStackCount, other.ItemStackCount))
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
		if (cLAFNDLGDAO_ != null)
		{
			num ^= CLAFNDLGDAO.GetHashCode();
		}
		if (hMFCCFCKEFO_ != null)
		{
			num ^= HMFCCFCKEFO.GetHashCode();
		}
		num ^= eCAJLPAJEKF_.GetHashCode();
		if (itemStackCount_ != null)
		{
			num ^= ItemStackCount.GetHashCode();
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
		if (cLAFNDLGDAO_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CLAFNDLGDAO);
		}
		if (hMFCCFCKEFO_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(HMFCCFCKEFO);
		}
		eCAJLPAJEKF_.WriteTo(ref output, _repeated_eCAJLPAJEKF_codec);
		if (itemStackCount_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(ItemStackCount);
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
		if (cLAFNDLGDAO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CLAFNDLGDAO);
		}
		if (hMFCCFCKEFO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMFCCFCKEFO);
		}
		num += eCAJLPAJEKF_.CalculateSize(_repeated_eCAJLPAJEKF_codec);
		if (itemStackCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemStackCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IIKMHADLJFL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cLAFNDLGDAO_ != null)
		{
			if (cLAFNDLGDAO_ == null)
			{
				CLAFNDLGDAO = new EFEGKDHEMFN();
			}
			CLAFNDLGDAO.MergeFrom(other.CLAFNDLGDAO);
		}
		if (other.hMFCCFCKEFO_ != null)
		{
			if (hMFCCFCKEFO_ == null)
			{
				HMFCCFCKEFO = new EFEGKDHEMFN();
			}
			HMFCCFCKEFO.MergeFrom(other.HMFCCFCKEFO);
		}
		eCAJLPAJEKF_.Add(other.eCAJLPAJEKF_);
		if (other.itemStackCount_ != null)
		{
			if (itemStackCount_ == null)
			{
				ItemStackCount = new EFEGKDHEMFN();
			}
			ItemStackCount.MergeFrom(other.ItemStackCount);
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
			case 26u:
				if (cLAFNDLGDAO_ == null)
				{
					CLAFNDLGDAO = new EFEGKDHEMFN();
				}
				input.ReadMessage(CLAFNDLGDAO);
				break;
			case 66u:
				if (hMFCCFCKEFO_ == null)
				{
					HMFCCFCKEFO = new EFEGKDHEMFN();
				}
				input.ReadMessage(HMFCCFCKEFO);
				break;
			case 88u:
			case 90u:
				eCAJLPAJEKF_.AddEntriesFrom(ref input, _repeated_eCAJLPAJEKF_codec);
				break;
			case 114u:
				if (itemStackCount_ == null)
				{
					ItemStackCount = new EFEGKDHEMFN();
				}
				input.ReadMessage(ItemStackCount);
				break;
			}
		}
	}
}
