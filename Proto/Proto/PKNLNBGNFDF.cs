using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PKNLNBGNFDF : IMessage<PKNLNBGNFDF>, IMessage, IEquatable<PKNLNBGNFDF>, IDeepCloneable<PKNLNBGNFDF>, IBufferMessage
{
	private static readonly MessageParser<PKNLNBGNFDF> _parser = new MessageParser<PKNLNBGNFDF>(() => new PKNLNBGNFDF());

	private UnknownFieldSet _unknownFields;

	public const int DGJHEEPIGLHFieldNumber = 10;

	private bool dGJHEEPIGLH_;

	public const int BGDGGALAODOFieldNumber = 12;

	private DMAJILEBABM bGDGGALAODO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PKNLNBGNFDF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PKNLNBGNFDFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DGJHEEPIGLH
	{
		get
		{
			return dGJHEEPIGLH_;
		}
		set
		{
			dGJHEEPIGLH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMAJILEBABM BGDGGALAODO
	{
		get
		{
			return bGDGGALAODO_;
		}
		set
		{
			bGDGGALAODO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKNLNBGNFDF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKNLNBGNFDF(PKNLNBGNFDF other)
		: this()
	{
		dGJHEEPIGLH_ = other.dGJHEEPIGLH_;
		bGDGGALAODO_ = ((other.bGDGGALAODO_ != null) ? other.bGDGGALAODO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKNLNBGNFDF Clone()
	{
		return new PKNLNBGNFDF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PKNLNBGNFDF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PKNLNBGNFDF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DGJHEEPIGLH != other.DGJHEEPIGLH)
		{
			return false;
		}
		if (!object.Equals(BGDGGALAODO, other.BGDGGALAODO))
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
		if (DGJHEEPIGLH)
		{
			num ^= DGJHEEPIGLH.GetHashCode();
		}
		if (bGDGGALAODO_ != null)
		{
			num ^= BGDGGALAODO.GetHashCode();
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
		if (DGJHEEPIGLH)
		{
			output.WriteRawTag(80);
			output.WriteBool(DGJHEEPIGLH);
		}
		if (bGDGGALAODO_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(BGDGGALAODO);
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
		if (DGJHEEPIGLH)
		{
			num += 2;
		}
		if (bGDGGALAODO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGDGGALAODO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PKNLNBGNFDF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DGJHEEPIGLH)
		{
			DGJHEEPIGLH = other.DGJHEEPIGLH;
		}
		if (other.bGDGGALAODO_ != null)
		{
			if (bGDGGALAODO_ == null)
			{
				BGDGGALAODO = new DMAJILEBABM();
			}
			BGDGGALAODO.MergeFrom(other.BGDGGALAODO);
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
			case 80u:
				DGJHEEPIGLH = input.ReadBool();
				break;
			case 98u:
				if (bGDGGALAODO_ == null)
				{
					BGDGGALAODO = new DMAJILEBABM();
				}
				input.ReadMessage(BGDGGALAODO);
				break;
			}
		}
	}
}
