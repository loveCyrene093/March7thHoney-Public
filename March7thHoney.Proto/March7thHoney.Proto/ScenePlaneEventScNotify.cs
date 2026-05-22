using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ScenePlaneEventScNotify : IMessage<ScenePlaneEventScNotify>, IMessage, IEquatable<ScenePlaneEventScNotify>, IDeepCloneable<ScenePlaneEventScNotify>, IBufferMessage
{
	private static readonly MessageParser<ScenePlaneEventScNotify> _parser = new MessageParser<ScenePlaneEventScNotify>(() => new ScenePlaneEventScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GetItemListFieldNumber = 2;

	private ItemList getItemList_;

	public const int EAOMBJJHMMAFieldNumber = 5;

	private ItemList eAOMBJJHMMA_;

	public const int CIDPONMOMIOFieldNumber = 7;

	private ItemList cIDPONMOMIO_;

	public const int KJJKHKFCPMAFieldNumber = 13;

	private ItemList kJJKHKFCPMA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ScenePlaneEventScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ScenePlaneEventScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList GetItemList
	{
		get
		{
			return getItemList_;
		}
		set
		{
			getItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList EAOMBJJHMMA
	{
		get
		{
			return eAOMBJJHMMA_;
		}
		set
		{
			eAOMBJJHMMA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList CIDPONMOMIO
	{
		get
		{
			return cIDPONMOMIO_;
		}
		set
		{
			cIDPONMOMIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList KJJKHKFCPMA
	{
		get
		{
			return kJJKHKFCPMA_;
		}
		set
		{
			kJJKHKFCPMA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScenePlaneEventScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScenePlaneEventScNotify(ScenePlaneEventScNotify other)
		: this()
	{
		getItemList_ = ((other.getItemList_ != null) ? other.getItemList_.Clone() : null);
		eAOMBJJHMMA_ = ((other.eAOMBJJHMMA_ != null) ? other.eAOMBJJHMMA_.Clone() : null);
		cIDPONMOMIO_ = ((other.cIDPONMOMIO_ != null) ? other.cIDPONMOMIO_.Clone() : null);
		kJJKHKFCPMA_ = ((other.kJJKHKFCPMA_ != null) ? other.kJJKHKFCPMA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScenePlaneEventScNotify Clone()
	{
		return new ScenePlaneEventScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ScenePlaneEventScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ScenePlaneEventScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GetItemList, other.GetItemList))
		{
			return false;
		}
		if (!object.Equals(EAOMBJJHMMA, other.EAOMBJJHMMA))
		{
			return false;
		}
		if (!object.Equals(CIDPONMOMIO, other.CIDPONMOMIO))
		{
			return false;
		}
		if (!object.Equals(KJJKHKFCPMA, other.KJJKHKFCPMA))
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
		if (getItemList_ != null)
		{
			num ^= GetItemList.GetHashCode();
		}
		if (eAOMBJJHMMA_ != null)
		{
			num ^= EAOMBJJHMMA.GetHashCode();
		}
		if (cIDPONMOMIO_ != null)
		{
			num ^= CIDPONMOMIO.GetHashCode();
		}
		if (kJJKHKFCPMA_ != null)
		{
			num ^= KJJKHKFCPMA.GetHashCode();
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
		if (getItemList_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(GetItemList);
		}
		if (eAOMBJJHMMA_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(EAOMBJJHMMA);
		}
		if (cIDPONMOMIO_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(CIDPONMOMIO);
		}
		if (kJJKHKFCPMA_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(KJJKHKFCPMA);
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
		if (getItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GetItemList);
		}
		if (eAOMBJJHMMA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EAOMBJJHMMA);
		}
		if (cIDPONMOMIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CIDPONMOMIO);
		}
		if (kJJKHKFCPMA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KJJKHKFCPMA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ScenePlaneEventScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.getItemList_ != null)
		{
			if (getItemList_ == null)
			{
				GetItemList = new ItemList();
			}
			GetItemList.MergeFrom(other.GetItemList);
		}
		if (other.eAOMBJJHMMA_ != null)
		{
			if (eAOMBJJHMMA_ == null)
			{
				EAOMBJJHMMA = new ItemList();
			}
			EAOMBJJHMMA.MergeFrom(other.EAOMBJJHMMA);
		}
		if (other.cIDPONMOMIO_ != null)
		{
			if (cIDPONMOMIO_ == null)
			{
				CIDPONMOMIO = new ItemList();
			}
			CIDPONMOMIO.MergeFrom(other.CIDPONMOMIO);
		}
		if (other.kJJKHKFCPMA_ != null)
		{
			if (kJJKHKFCPMA_ == null)
			{
				KJJKHKFCPMA = new ItemList();
			}
			KJJKHKFCPMA.MergeFrom(other.KJJKHKFCPMA);
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
			case 18u:
				if (getItemList_ == null)
				{
					GetItemList = new ItemList();
				}
				input.ReadMessage(GetItemList);
				break;
			case 42u:
				if (eAOMBJJHMMA_ == null)
				{
					EAOMBJJHMMA = new ItemList();
				}
				input.ReadMessage(EAOMBJJHMMA);
				break;
			case 58u:
				if (cIDPONMOMIO_ == null)
				{
					CIDPONMOMIO = new ItemList();
				}
				input.ReadMessage(CIDPONMOMIO);
				break;
			case 106u:
				if (kJJKHKFCPMA_ == null)
				{
					KJJKHKFCPMA = new ItemList();
				}
				input.ReadMessage(KJJKHKFCPMA);
				break;
			}
		}
	}
}
