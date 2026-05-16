using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MIGEAHDEBOE : IMessage<MIGEAHDEBOE>, IMessage, IEquatable<MIGEAHDEBOE>, IDeepCloneable<MIGEAHDEBOE>, IBufferMessage
{
	private static readonly MessageParser<MIGEAHDEBOE> _parser = new MessageParser<MIGEAHDEBOE>(() => new MIGEAHDEBOE());

	private UnknownFieldSet _unknownFields;

	public const int OJLAODIALLEFieldNumber = 1;

	private GridFightTalentInfo oJLAODIALLE_;

	public const int IMNOJIDJBNGFieldNumber = 8;

	private NHDKLMIMLKC iMNOJIDJBNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MIGEAHDEBOE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MIGEAHDEBOEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTalentInfo OJLAODIALLE
	{
		get
		{
			return oJLAODIALLE_;
		}
		set
		{
			oJLAODIALLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHDKLMIMLKC IMNOJIDJBNG
	{
		get
		{
			return iMNOJIDJBNG_;
		}
		set
		{
			iMNOJIDJBNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIGEAHDEBOE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIGEAHDEBOE(MIGEAHDEBOE other)
		: this()
	{
		oJLAODIALLE_ = ((other.oJLAODIALLE_ != null) ? other.oJLAODIALLE_.Clone() : null);
		iMNOJIDJBNG_ = ((other.iMNOJIDJBNG_ != null) ? other.iMNOJIDJBNG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIGEAHDEBOE Clone()
	{
		return new MIGEAHDEBOE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MIGEAHDEBOE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MIGEAHDEBOE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OJLAODIALLE, other.OJLAODIALLE))
		{
			return false;
		}
		if (!object.Equals(IMNOJIDJBNG, other.IMNOJIDJBNG))
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
		if (oJLAODIALLE_ != null)
		{
			num ^= OJLAODIALLE.GetHashCode();
		}
		if (iMNOJIDJBNG_ != null)
		{
			num ^= IMNOJIDJBNG.GetHashCode();
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
		if (oJLAODIALLE_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(OJLAODIALLE);
		}
		if (iMNOJIDJBNG_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(IMNOJIDJBNG);
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
		if (oJLAODIALLE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OJLAODIALLE);
		}
		if (iMNOJIDJBNG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMNOJIDJBNG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MIGEAHDEBOE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oJLAODIALLE_ != null)
		{
			if (oJLAODIALLE_ == null)
			{
				OJLAODIALLE = new GridFightTalentInfo();
			}
			OJLAODIALLE.MergeFrom(other.OJLAODIALLE);
		}
		if (other.iMNOJIDJBNG_ != null)
		{
			if (iMNOJIDJBNG_ == null)
			{
				IMNOJIDJBNG = new NHDKLMIMLKC();
			}
			IMNOJIDJBNG.MergeFrom(other.IMNOJIDJBNG);
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
			case 10u:
				if (oJLAODIALLE_ == null)
				{
					OJLAODIALLE = new GridFightTalentInfo();
				}
				input.ReadMessage(OJLAODIALLE);
				break;
			case 66u:
				if (iMNOJIDJBNG_ == null)
				{
					IMNOJIDJBNG = new NHDKLMIMLKC();
				}
				input.ReadMessage(IMNOJIDJBNG);
				break;
			}
		}
	}
}
