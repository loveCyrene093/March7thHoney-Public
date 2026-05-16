using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdatePlayWithPsnOnlySettingCsReq : IMessage<UpdatePlayWithPsnOnlySettingCsReq>, IMessage, IEquatable<UpdatePlayWithPsnOnlySettingCsReq>, IDeepCloneable<UpdatePlayWithPsnOnlySettingCsReq>, IBufferMessage
{
	public enum HNIKGLBIMMIOneofCase
	{
		None = 0,
		AGJCGOHEGPL = 786,
		KNOEKHPLAAN = 931
	}

	private static readonly MessageParser<UpdatePlayWithPsnOnlySettingCsReq> _parser = new MessageParser<UpdatePlayWithPsnOnlySettingCsReq>(() => new UpdatePlayWithPsnOnlySettingCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AGJCGOHEGPLFieldNumber = 786;

	public const int KNOEKHPLAANFieldNumber = 931;

	private object hNIKGLBIMMI_;

	private HNIKGLBIMMIOneofCase hNIKGLBIMMICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdatePlayWithPsnOnlySettingCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdatePlayWithPsnOnlySettingCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEBHKHCALBO AGJCGOHEGPL
	{
		get
		{
			if (hNIKGLBIMMICase_ != HNIKGLBIMMIOneofCase.AGJCGOHEGPL)
			{
				return null;
			}
			return (KEBHKHCALBO)hNIKGLBIMMI_;
		}
		set
		{
			hNIKGLBIMMI_ = value;
			hNIKGLBIMMICase_ = ((value != null) ? HNIKGLBIMMIOneofCase.AGJCGOHEGPL : HNIKGLBIMMIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFLEELGMBIO KNOEKHPLAAN
	{
		get
		{
			if (hNIKGLBIMMICase_ != HNIKGLBIMMIOneofCase.KNOEKHPLAAN)
			{
				return null;
			}
			return (OFLEELGMBIO)hNIKGLBIMMI_;
		}
		set
		{
			hNIKGLBIMMI_ = value;
			hNIKGLBIMMICase_ = ((value != null) ? HNIKGLBIMMIOneofCase.KNOEKHPLAAN : HNIKGLBIMMIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HNIKGLBIMMIOneofCase HNIKGLBIMMICase => hNIKGLBIMMICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayWithPsnOnlySettingCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayWithPsnOnlySettingCsReq(UpdatePlayWithPsnOnlySettingCsReq other)
		: this()
	{
		switch (other.HNIKGLBIMMICase)
		{
		case HNIKGLBIMMIOneofCase.AGJCGOHEGPL:
			AGJCGOHEGPL = other.AGJCGOHEGPL.Clone();
			break;
		case HNIKGLBIMMIOneofCase.KNOEKHPLAAN:
			KNOEKHPLAAN = other.KNOEKHPLAAN.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayWithPsnOnlySettingCsReq Clone()
	{
		return new UpdatePlayWithPsnOnlySettingCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHNIKGLBIMMI()
	{
		hNIKGLBIMMICase_ = HNIKGLBIMMIOneofCase.None;
		hNIKGLBIMMI_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdatePlayWithPsnOnlySettingCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdatePlayWithPsnOnlySettingCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AGJCGOHEGPL, other.AGJCGOHEGPL))
		{
			return false;
		}
		if (!object.Equals(KNOEKHPLAAN, other.KNOEKHPLAAN))
		{
			return false;
		}
		if (HNIKGLBIMMICase != other.HNIKGLBIMMICase)
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
		if (hNIKGLBIMMICase_ == HNIKGLBIMMIOneofCase.AGJCGOHEGPL)
		{
			num ^= AGJCGOHEGPL.GetHashCode();
		}
		if (hNIKGLBIMMICase_ == HNIKGLBIMMIOneofCase.KNOEKHPLAAN)
		{
			num ^= KNOEKHPLAAN.GetHashCode();
		}
		num ^= (int)hNIKGLBIMMICase_;
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
		if (hNIKGLBIMMICase_ == HNIKGLBIMMIOneofCase.AGJCGOHEGPL)
		{
			output.WriteRawTag(146, 49);
			output.WriteMessage(AGJCGOHEGPL);
		}
		if (hNIKGLBIMMICase_ == HNIKGLBIMMIOneofCase.KNOEKHPLAAN)
		{
			output.WriteRawTag(154, 58);
			output.WriteMessage(KNOEKHPLAAN);
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
		if (hNIKGLBIMMICase_ == HNIKGLBIMMIOneofCase.AGJCGOHEGPL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AGJCGOHEGPL);
		}
		if (hNIKGLBIMMICase_ == HNIKGLBIMMIOneofCase.KNOEKHPLAAN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KNOEKHPLAAN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdatePlayWithPsnOnlySettingCsReq other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.HNIKGLBIMMICase)
		{
		case HNIKGLBIMMIOneofCase.AGJCGOHEGPL:
			if (AGJCGOHEGPL == null)
			{
				AGJCGOHEGPL = new KEBHKHCALBO();
			}
			AGJCGOHEGPL.MergeFrom(other.AGJCGOHEGPL);
			break;
		case HNIKGLBIMMIOneofCase.KNOEKHPLAAN:
			if (KNOEKHPLAAN == null)
			{
				KNOEKHPLAAN = new OFLEELGMBIO();
			}
			KNOEKHPLAAN.MergeFrom(other.KNOEKHPLAAN);
			break;
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
			case 6290u:
			{
				KEBHKHCALBO kEBHKHCALBO = new KEBHKHCALBO();
				if (hNIKGLBIMMICase_ == HNIKGLBIMMIOneofCase.AGJCGOHEGPL)
				{
					kEBHKHCALBO.MergeFrom(AGJCGOHEGPL);
				}
				input.ReadMessage(kEBHKHCALBO);
				AGJCGOHEGPL = kEBHKHCALBO;
				break;
			}
			case 7450u:
			{
				OFLEELGMBIO oFLEELGMBIO = new OFLEELGMBIO();
				if (hNIKGLBIMMICase_ == HNIKGLBIMMIOneofCase.KNOEKHPLAAN)
				{
					oFLEELGMBIO.MergeFrom(KNOEKHPLAAN);
				}
				input.ReadMessage(oFLEELGMBIO);
				KNOEKHPLAAN = oFLEELGMBIO;
				break;
			}
			}
		}
	}
}
