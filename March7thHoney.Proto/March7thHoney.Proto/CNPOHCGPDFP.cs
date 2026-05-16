using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNPOHCGPDFP : IMessage<CNPOHCGPDFP>, IMessage, IEquatable<CNPOHCGPDFP>, IDeepCloneable<CNPOHCGPDFP>, IBufferMessage
{
	private static readonly MessageParser<CNPOHCGPDFP> _parser = new MessageParser<CNPOHCGPDFP>(() => new CNPOHCGPDFP());

	private UnknownFieldSet _unknownFields;

	public const int HCBEDECLAICFieldNumber = 2;

	private bool hCBEDECLAIC_;

	public const int MLDBDNCCJDDFieldNumber = 5;

	private uint mLDBDNCCJDD_;

	public const int CBOJNKCBEDHFieldNumber = 8;

	private uint cBOJNKCBEDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNPOHCGPDFP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNPOHCGPDFPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HCBEDECLAIC
	{
		get
		{
			return hCBEDECLAIC_;
		}
		set
		{
			hCBEDECLAIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MLDBDNCCJDD
	{
		get
		{
			return mLDBDNCCJDD_;
		}
		set
		{
			mLDBDNCCJDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CBOJNKCBEDH
	{
		get
		{
			return cBOJNKCBEDH_;
		}
		set
		{
			cBOJNKCBEDH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNPOHCGPDFP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNPOHCGPDFP(CNPOHCGPDFP other)
		: this()
	{
		hCBEDECLAIC_ = other.hCBEDECLAIC_;
		mLDBDNCCJDD_ = other.mLDBDNCCJDD_;
		cBOJNKCBEDH_ = other.cBOJNKCBEDH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNPOHCGPDFP Clone()
	{
		return new CNPOHCGPDFP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNPOHCGPDFP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNPOHCGPDFP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCBEDECLAIC != other.HCBEDECLAIC)
		{
			return false;
		}
		if (MLDBDNCCJDD != other.MLDBDNCCJDD)
		{
			return false;
		}
		if (CBOJNKCBEDH != other.CBOJNKCBEDH)
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
		if (HCBEDECLAIC)
		{
			num ^= HCBEDECLAIC.GetHashCode();
		}
		if (MLDBDNCCJDD != 0)
		{
			num ^= MLDBDNCCJDD.GetHashCode();
		}
		if (CBOJNKCBEDH != 0)
		{
			num ^= CBOJNKCBEDH.GetHashCode();
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
		if (HCBEDECLAIC)
		{
			output.WriteRawTag(16);
			output.WriteBool(HCBEDECLAIC);
		}
		if (MLDBDNCCJDD != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(MLDBDNCCJDD);
		}
		if (CBOJNKCBEDH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CBOJNKCBEDH);
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
		if (HCBEDECLAIC)
		{
			num += 2;
		}
		if (MLDBDNCCJDD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MLDBDNCCJDD);
		}
		if (CBOJNKCBEDH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBOJNKCBEDH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CNPOHCGPDFP other)
	{
		if (other != null)
		{
			if (other.HCBEDECLAIC)
			{
				HCBEDECLAIC = other.HCBEDECLAIC;
			}
			if (other.MLDBDNCCJDD != 0)
			{
				MLDBDNCCJDD = other.MLDBDNCCJDD;
			}
			if (other.CBOJNKCBEDH != 0)
			{
				CBOJNKCBEDH = other.CBOJNKCBEDH;
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
			case 16u:
				HCBEDECLAIC = input.ReadBool();
				break;
			case 40u:
				MLDBDNCCJDD = input.ReadUInt32();
				break;
			case 64u:
				CBOJNKCBEDH = input.ReadUInt32();
				break;
			}
		}
	}
}
