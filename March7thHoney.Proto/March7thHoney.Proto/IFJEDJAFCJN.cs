using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFJEDJAFCJN : IMessage<IFJEDJAFCJN>, IMessage, IEquatable<IFJEDJAFCJN>, IDeepCloneable<IFJEDJAFCJN>, IBufferMessage
{
	public enum OAIJOPKPDGJOneofCase
	{
		None = 0,
		MNIOMFOAMFH = 11,
		APDHGALNKEC = 14
	}

	private static readonly MessageParser<IFJEDJAFCJN> _parser = new MessageParser<IFJEDJAFCJN>(() => new IFJEDJAFCJN());

	private UnknownFieldSet _unknownFields;

	public const int MNIOMFOAMFHFieldNumber = 11;

	public const int APDHGALNKECFieldNumber = 14;

	private object oAIJOPKPDGJ_;

	private OAIJOPKPDGJOneofCase oAIJOPKPDGJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFJEDJAFCJN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFJEDJAFCJNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IADMEOMIIFI MNIOMFOAMFH
	{
		get
		{
			if (oAIJOPKPDGJCase_ != OAIJOPKPDGJOneofCase.MNIOMFOAMFH)
			{
				return null;
			}
			return (IADMEOMIIFI)oAIJOPKPDGJ_;
		}
		set
		{
			oAIJOPKPDGJ_ = value;
			oAIJOPKPDGJCase_ = ((value != null) ? OAIJOPKPDGJOneofCase.MNIOMFOAMFH : OAIJOPKPDGJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMCICPOHAAL APDHGALNKEC
	{
		get
		{
			if (oAIJOPKPDGJCase_ != OAIJOPKPDGJOneofCase.APDHGALNKEC)
			{
				return null;
			}
			return (EMCICPOHAAL)oAIJOPKPDGJ_;
		}
		set
		{
			oAIJOPKPDGJ_ = value;
			oAIJOPKPDGJCase_ = ((value != null) ? OAIJOPKPDGJOneofCase.APDHGALNKEC : OAIJOPKPDGJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAIJOPKPDGJOneofCase OAIJOPKPDGJCase => oAIJOPKPDGJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFJEDJAFCJN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFJEDJAFCJN(IFJEDJAFCJN other)
		: this()
	{
		switch (other.OAIJOPKPDGJCase)
		{
		case OAIJOPKPDGJOneofCase.MNIOMFOAMFH:
			MNIOMFOAMFH = other.MNIOMFOAMFH.Clone();
			break;
		case OAIJOPKPDGJOneofCase.APDHGALNKEC:
			APDHGALNKEC = other.APDHGALNKEC.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFJEDJAFCJN Clone()
	{
		return new IFJEDJAFCJN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearOAIJOPKPDGJ()
	{
		oAIJOPKPDGJCase_ = OAIJOPKPDGJOneofCase.None;
		oAIJOPKPDGJ_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFJEDJAFCJN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFJEDJAFCJN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MNIOMFOAMFH, other.MNIOMFOAMFH))
		{
			return false;
		}
		if (!object.Equals(APDHGALNKEC, other.APDHGALNKEC))
		{
			return false;
		}
		if (OAIJOPKPDGJCase != other.OAIJOPKPDGJCase)
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
		if (oAIJOPKPDGJCase_ == OAIJOPKPDGJOneofCase.MNIOMFOAMFH)
		{
			num ^= MNIOMFOAMFH.GetHashCode();
		}
		if (oAIJOPKPDGJCase_ == OAIJOPKPDGJOneofCase.APDHGALNKEC)
		{
			num ^= APDHGALNKEC.GetHashCode();
		}
		num ^= (int)oAIJOPKPDGJCase_;
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
		if (oAIJOPKPDGJCase_ == OAIJOPKPDGJOneofCase.MNIOMFOAMFH)
		{
			output.WriteRawTag(90);
			output.WriteMessage(MNIOMFOAMFH);
		}
		if (oAIJOPKPDGJCase_ == OAIJOPKPDGJOneofCase.APDHGALNKEC)
		{
			output.WriteRawTag(114);
			output.WriteMessage(APDHGALNKEC);
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
		if (oAIJOPKPDGJCase_ == OAIJOPKPDGJOneofCase.MNIOMFOAMFH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNIOMFOAMFH);
		}
		if (oAIJOPKPDGJCase_ == OAIJOPKPDGJOneofCase.APDHGALNKEC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(APDHGALNKEC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFJEDJAFCJN other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.OAIJOPKPDGJCase)
		{
		case OAIJOPKPDGJOneofCase.MNIOMFOAMFH:
			if (MNIOMFOAMFH == null)
			{
				MNIOMFOAMFH = new IADMEOMIIFI();
			}
			MNIOMFOAMFH.MergeFrom(other.MNIOMFOAMFH);
			break;
		case OAIJOPKPDGJOneofCase.APDHGALNKEC:
			if (APDHGALNKEC == null)
			{
				APDHGALNKEC = new EMCICPOHAAL();
			}
			APDHGALNKEC.MergeFrom(other.APDHGALNKEC);
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
			case 90u:
			{
				IADMEOMIIFI iADMEOMIIFI = new IADMEOMIIFI();
				if (oAIJOPKPDGJCase_ == OAIJOPKPDGJOneofCase.MNIOMFOAMFH)
				{
					iADMEOMIIFI.MergeFrom(MNIOMFOAMFH);
				}
				input.ReadMessage(iADMEOMIIFI);
				MNIOMFOAMFH = iADMEOMIIFI;
				break;
			}
			case 114u:
			{
				EMCICPOHAAL eMCICPOHAAL = new EMCICPOHAAL();
				if (oAIJOPKPDGJCase_ == OAIJOPKPDGJOneofCase.APDHGALNKEC)
				{
					eMCICPOHAAL.MergeFrom(APDHGALNKEC);
				}
				input.ReadMessage(eMCICPOHAAL);
				APDHGALNKEC = eMCICPOHAAL;
				break;
			}
			}
		}
	}
}
