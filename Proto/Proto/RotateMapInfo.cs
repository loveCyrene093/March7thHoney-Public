using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RotateMapInfo : IMessage<RotateMapInfo>, IMessage, IEquatable<RotateMapInfo>, IDeepCloneable<RotateMapInfo>, IBufferMessage
{
	private static readonly MessageParser<RotateMapInfo> _parser = new MessageParser<RotateMapInfo>(() => new RotateMapInfo());

	private UnknownFieldSet _unknownFields;

	public const int JOGBJIBEEEBFieldNumber = 8;

	private Vector4 jOGBJIBEEEB_;

	public const int LGKMEPOJACIFieldNumber = 11;

	private Vector lGKMEPOJACI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RotateMapInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RotateMapInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector4 JOGBJIBEEEB
	{
		get
		{
			return jOGBJIBEEEB_;
		}
		set
		{
			jOGBJIBEEEB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector LGKMEPOJACI
	{
		get
		{
			return lGKMEPOJACI_;
		}
		set
		{
			lGKMEPOJACI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotateMapInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotateMapInfo(RotateMapInfo other)
		: this()
	{
		jOGBJIBEEEB_ = ((other.jOGBJIBEEEB_ != null) ? other.jOGBJIBEEEB_.Clone() : null);
		lGKMEPOJACI_ = ((other.lGKMEPOJACI_ != null) ? other.lGKMEPOJACI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotateMapInfo Clone()
	{
		return new RotateMapInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RotateMapInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RotateMapInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JOGBJIBEEEB, other.JOGBJIBEEEB))
		{
			return false;
		}
		if (!object.Equals(LGKMEPOJACI, other.LGKMEPOJACI))
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
		if (jOGBJIBEEEB_ != null)
		{
			num ^= JOGBJIBEEEB.GetHashCode();
		}
		if (lGKMEPOJACI_ != null)
		{
			num ^= LGKMEPOJACI.GetHashCode();
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
		if (jOGBJIBEEEB_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(JOGBJIBEEEB);
		}
		if (lGKMEPOJACI_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(LGKMEPOJACI);
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
		if (jOGBJIBEEEB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JOGBJIBEEEB);
		}
		if (lGKMEPOJACI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LGKMEPOJACI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RotateMapInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jOGBJIBEEEB_ != null)
		{
			if (jOGBJIBEEEB_ == null)
			{
				JOGBJIBEEEB = new Vector4();
			}
			JOGBJIBEEEB.MergeFrom(other.JOGBJIBEEEB);
		}
		if (other.lGKMEPOJACI_ != null)
		{
			if (lGKMEPOJACI_ == null)
			{
				LGKMEPOJACI = new Vector();
			}
			LGKMEPOJACI.MergeFrom(other.LGKMEPOJACI);
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
			case 66u:
				if (jOGBJIBEEEB_ == null)
				{
					JOGBJIBEEEB = new Vector4();
				}
				input.ReadMessage(JOGBJIBEEEB);
				break;
			case 90u:
				if (lGKMEPOJACI_ == null)
				{
					LGKMEPOJACI = new Vector();
				}
				input.ReadMessage(LGKMEPOJACI);
				break;
			}
		}
	}
}
