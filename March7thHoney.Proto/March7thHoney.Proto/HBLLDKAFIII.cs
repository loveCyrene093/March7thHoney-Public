using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HBLLDKAFIII : IMessage<HBLLDKAFIII>, IMessage, IEquatable<HBLLDKAFIII>, IDeepCloneable<HBLLDKAFIII>, IBufferMessage
{
	private static readonly MessageParser<HBLLDKAFIII> _parser = new MessageParser<HBLLDKAFIII>(() => new HBLLDKAFIII());

	private UnknownFieldSet _unknownFields;

	public const int EEKGGBLHNHPFieldNumber = 4;

	private LKDFOOJMHIE eEKGGBLHNHP_;

	public const int BOKMCBHOCIKFieldNumber = 8;

	private LKDFOOJMHIE bOKMCBHOCIK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HBLLDKAFIII> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HBLLDKAFIIIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKDFOOJMHIE EEKGGBLHNHP
	{
		get
		{
			return eEKGGBLHNHP_;
		}
		set
		{
			eEKGGBLHNHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKDFOOJMHIE BOKMCBHOCIK
	{
		get
		{
			return bOKMCBHOCIK_;
		}
		set
		{
			bOKMCBHOCIK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBLLDKAFIII()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBLLDKAFIII(HBLLDKAFIII other)
		: this()
	{
		eEKGGBLHNHP_ = ((other.eEKGGBLHNHP_ != null) ? other.eEKGGBLHNHP_.Clone() : null);
		bOKMCBHOCIK_ = ((other.bOKMCBHOCIK_ != null) ? other.bOKMCBHOCIK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBLLDKAFIII Clone()
	{
		return new HBLLDKAFIII(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HBLLDKAFIII);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HBLLDKAFIII other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EEKGGBLHNHP, other.EEKGGBLHNHP))
		{
			return false;
		}
		if (!object.Equals(BOKMCBHOCIK, other.BOKMCBHOCIK))
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
		if (eEKGGBLHNHP_ != null)
		{
			num ^= EEKGGBLHNHP.GetHashCode();
		}
		if (bOKMCBHOCIK_ != null)
		{
			num ^= BOKMCBHOCIK.GetHashCode();
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
		if (eEKGGBLHNHP_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(EEKGGBLHNHP);
		}
		if (bOKMCBHOCIK_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BOKMCBHOCIK);
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
		if (eEKGGBLHNHP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EEKGGBLHNHP);
		}
		if (bOKMCBHOCIK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BOKMCBHOCIK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HBLLDKAFIII other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eEKGGBLHNHP_ != null)
		{
			if (eEKGGBLHNHP_ == null)
			{
				EEKGGBLHNHP = new LKDFOOJMHIE();
			}
			EEKGGBLHNHP.MergeFrom(other.EEKGGBLHNHP);
		}
		if (other.bOKMCBHOCIK_ != null)
		{
			if (bOKMCBHOCIK_ == null)
			{
				BOKMCBHOCIK = new LKDFOOJMHIE();
			}
			BOKMCBHOCIK.MergeFrom(other.BOKMCBHOCIK);
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
			case 34u:
				if (eEKGGBLHNHP_ == null)
				{
					EEKGGBLHNHP = new LKDFOOJMHIE();
				}
				input.ReadMessage(EEKGGBLHNHP);
				break;
			case 66u:
				if (bOKMCBHOCIK_ == null)
				{
					BOKMCBHOCIK = new LKDFOOJMHIE();
				}
				input.ReadMessage(BOKMCBHOCIK);
				break;
			}
		}
	}
}
